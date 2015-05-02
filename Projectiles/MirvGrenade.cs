using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

using TAPI;
using Terraria;

namespace jThrowables.Projectiles
{
    public class MirvGrenade : ModProjectile
    {

        public override void PostKill()
        {
            Main.PlaySound(14, (int)projectile.position.X, (int)projectile.position.Y, 2);
                float speedX = projectile.velocity.X * (float)Main.rand.Next(3) * 0.5f;
                float speedY = projectile.velocity.Y * 0.3f;
                int mg = ProjDef.byName["jThrowables:MiniGrenade"].type;
                int me = ProjDef.byName["jThrowables:MirvGrenadeExplosion"].type;
                Projectile.NewProjectile(projectile.position.X, projectile.position.Y, 0, 0, me, 78, 0, projectile.whoAmI);
            if (Main.rand.Next(3) == 0)
            {
                Projectile.NewProjectile(projectile.position.X + 7.0f, projectile.position.Y + 20.0f, speedX, speedY, mg, 5, 0, projectile.whoAmI);
            }
            if (Main.rand.Next(4) == 0)
            {
                Projectile.NewProjectile(projectile.position.X + 9.0f, projectile.position.Y + 20.0f, speedX, speedY, mg, 4, 0, projectile.whoAmI);
            }
            if (Main.rand.Next(6) == 0)
            {
                Projectile.NewProjectile(projectile.position.X - 9.0f, projectile.position.Y + 9.0f, speedX, speedY, mg, 7, 0, projectile.whoAmI);
            }
            if (Main.rand.Next(3) == 0)
            {
                Projectile.NewProjectile(projectile.position.X + 2.0f, projectile.position.Y + 9.0f, speedX, speedY, mg, 7, 0, projectile.whoAmI);
            }
            }
        }
    }
