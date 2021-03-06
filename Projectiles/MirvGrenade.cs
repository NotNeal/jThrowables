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
            float speedX = (float)Main.rand.Next(3) * 1.0f;
            float speedY = -3.5f;
            int mg = ProjDef.byName["jThrowables:MiniGrenade"].type;
            Main.PlaySound(2, (int)projectile.position.X, (int)projectile.position.Y, 14);
            float X = projectile.position.X + (float)(projectile.width / 2);
            float Y = projectile.position.Y + (float)(projectile.height / 2);
            int mge = ProjDef.byName["jThrowables:MirvGrenadeExplosion"].type;
            Projectile.NewProjectile(X, Y, 0, 0, mge, 100, 0, projectile.whoAmI);
            if (Main.rand.Next(1) == 0)
            {
                Projectile.NewProjectile(projectile.position.X + 2.0f, projectile.position.Y, speedX, speedY, mg, 0, 0, projectile.whoAmI);
            }
            if (Main.rand.Next(1) == 0)
            {
                Projectile.NewProjectile(projectile.position.X + 3.0f, projectile.position.Y, speedX, speedY, mg, 0, 0, projectile.whoAmI);
            }
            if (Main.rand.Next(1) == 0)
            {
                Projectile.NewProjectile(projectile.position.X - 2.0f, projectile.position.Y, speedX, speedY, mg, 0, 0, projectile.whoAmI);
            }
            if (Main.rand.Next(2) == 0)
            {
                Projectile.NewProjectile(projectile.position.X + 2.5f, projectile.position.Y, speedX, speedY, mg, 0, 0, projectile.whoAmI);
            }
            {
                int i = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 31, 0f, 0f, 100, default(Color), 1.5f);
                Main.dust[i].velocity *= 1.4f;
            }
            int num373 = Gore.NewGore(new Vector2(projectile.position.X - 9f, projectile.position.Y - 9f), default(Vector2), Main.rand.Next(61, 64), 1f);
            Main.gore[num373].velocity *= 0.4f;
            Gore gore85 = Main.gore[num373];
            gore85.velocity.X = gore85.velocity.X + 1f;
            Gore gore86 = Main.gore[num373];
            gore86.velocity.Y = gore86.velocity.Y + 1f;
            num373 = Gore.NewGore(new Vector2(projectile.position.X - 9f, projectile.position.Y - 9f), default(Vector2), Main.rand.Next(61, 64), 1f);
            Main.gore[num373].velocity *= 0.4f;
            Gore gore87 = Main.gore[num373];
            gore87.velocity.X = gore87.velocity.X - 1f;
            Gore gore88 = Main.gore[num373];
            gore88.velocity.Y = gore88.velocity.Y + 1f;
            num373 = Gore.NewGore(new Vector2(projectile.position.X - 9f, projectile.position.Y - 9f), default(Vector2), Main.rand.Next(61, 64), 1f);
            Main.gore[num373].velocity *= 0.4f;
            Gore gore89 = Main.gore[num373];
            gore89.velocity.X = gore89.velocity.X + 1f;
            Gore gore90 = Main.gore[num373];
            gore90.velocity.Y = gore90.velocity.Y - 1f;
            num373 = Gore.NewGore(new Vector2(projectile.position.X - 9f, projectile.position.Y - 9f), default(Vector2), Main.rand.Next(61, 64), 1f);
            Main.gore[num373].velocity *= 0.4f;
            Gore gore91 = Main.gore[num373];
            gore91.velocity.X = gore91.velocity.X - 1f;
            Gore gore92 = Main.gore[num373];
            gore92.velocity.Y = gore92.velocity.Y - 1f;
            }
        }
    }
