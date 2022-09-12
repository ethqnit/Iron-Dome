using Godot;
using System;

public class player : Node
{
    bulletBrain bulletBrain;
    public bool canShoot = true;
    public bool gameOver = false;
    [Export] public int health = 3;
    public int score = 0;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        bulletBrain = (bulletBrain)GetNode("/root/game/bullets/bulletBrain");
        updateUI();
    }

    public override void _Input(InputEvent _inputEvent)
    {
        if((_inputEvent.IsActionPressed("click") && (gameOver == true)))
        {
            GetTree().ReloadCurrentScene();
        }
    }

    public void _on_playerHitZone_area_entered(Area2D bullet)
    {
        var bulletType = (AnimatedSprite)bullet.GetNodeOrNull("AnimatedSprite");

       if((bulletType != null) && (bulletType.Animation == "enemy") && (bullet is bullet))
       {
            //bulletBrain.spawnExplosion(bullet.GlobalPosition,"enemy");
            bulletBrain.CallDeferred("spawnExplosion", bullet.GlobalPosition,"enemy"); 
            bullet.QueueFree();
            hitPlayer();
       }
    }

    public void hitPlayer(int damageAmount = 1)
    {
        health = Math.Max(health-damageAmount, 0);
        updateUI();
        if((health <= 0) && (gameOver != true))
        {
            gameOver = true;
            canShoot = false;
            var gameOverScreen = (Node2D)GetNode("/root/game/hud/gameOverSceen");
            gameOverScreen.Visible = true;

            var cannon = (Node2D)GetNode("/root/game/foreground/Cannon");
            //bulletBrain.spawnExplosion(cannon.GlobalPosition, "enemy");
            bulletBrain.CallDeferred("spawnExplosion", cannon.GlobalPosition, "enemy");
            cannon.QueueFree();
            request();
        }
    }
    public void request()
    {
         HTTPRequest httpRequest = GetNode<HTTPRequest>("HTTPRequest");
        string value = string.Format("{0}", score);
        httpRequest.Request("https://www.dreamlo.com/lb/6UMHsdQMFUSQ9byCcbPTdAWY9PSV5Y8kCwCqp6o12czA/add/AlphaTestPlayer/"+ score);

    }
    public void addScore(int scoreAmount = 1)
    {
        score += scoreAmount;
        updateUI();
        bulletBrain.increaseDifficulty();
    }

    public void updateUI()
    {
        var healthAndScore = (Label)GetNode("/root/game/hud/healthAndScore");
        var newHudText = "HEALTH: " + health + "     " + "SCORE: " + score;
        healthAndScore.Text = newHudText;
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
