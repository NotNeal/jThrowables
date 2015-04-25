using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

using TAPI;
using Terraria;

namespace jThrowables.Projectiles
{
    public class CursedKnive : ModProjectile
    {
        public override void DealtNPC(NPC n, int hitDir, int dmgDealt, float knockback, bool crit)
        {
            n.AddBuff(39, 90, false);
        }

        public override void DealtPVP(Player p, int hitDir, int dmgDealt, bool crit)
        {
            p.AddBuff(39, 30, false);
        }
        public override void PostAI()
        {
		    float speedX = projectile.velocity.X * (float)Main.rand.Next(5) * 0.5f;
		    float speedY = projectile.velocity.Y * (float)Main.rand.Next(5) * 0.3f;

                if (Main.rand.Next(3) == 0)
            {
                int i = Dust.NewDust(projectile.position, projectile.width, projectile.height, 74, speedX, speedY, 80, default(Color), 1.2f);
                Main.dust[i].noGravity = true;
                int j = Dust.NewDust(projectile.position, projectile.width, projectile.height, 74, speedX, speedY, 65, default(Color), 0.8f);
                Main.dust[j].noGravity = true;
            }
	    }
    }
}