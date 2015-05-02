using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

using TAPI;
using Terraria;

namespace jThrowables.Projectiles
{
    public class HellfireKnive : ModProjectile
    {
        public override void PostAI()
        {
            float speedX = projectile.velocity.X * (float)Main.rand.Next(3) * 0.2f;
            float speedY = projectile.velocity.Y * (float)Main.rand.Next(3) * 0.2f;
            {
                if (Main.rand.Next(3) == 0)
                {
                int i = Dust.NewDust(projectile.position, projectile.width, projectile.height, 6, speedX, speedY, 5, default(Color), 1.5f);
                Main.dust[i].noGravity = true;
                int j = Dust.NewDust(projectile.position, projectile.width, projectile.height, 6, speedX, speedY, 5, default(Color), 1.9f);
                Main.dust[j].noGravity = true;
                }
            }
        }
        public override void PostKill()
        {
            {
            Main.PlaySound(0, (int)projectile.position.X, (int)projectile.position.Y, 1);
                
                if (Main.rand.Next(3) == 0)
                {
                int hk = ItemDef.byName["jThrowables:Hellfire Knive"].type;
                Item.NewItem((int) projectile.position.X, (int) projectile.position.Y, projectile.width, projectile.height, hk, 1, false, 0, false);   
            }
        }
    }
}
}