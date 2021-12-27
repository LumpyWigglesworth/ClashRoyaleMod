using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria;

namespace ClashRoyaleMod.Projectiles
{
    class TheLog : ModProjectile
    {
        protected float spinRate = (float)Math.PI/30;
        protected float bounce = -0.65f;
        //float lateralSpeed = 10f;
        public override void SetDefaults()
        {
            projectile.width = 60;
            projectile.height = 60;
            projectile.penetrate = -1;
            projectile.magic = true;
            projectile.hostile = false;
            projectile.friendly = true;
            projectile.ignoreWater = true;
            projectile.tileCollide = false;
            projectile.localAI[1] = 0f;
            projectile.localAI[0] = 0f;
            projectile.timeLeft = 180;
        }
        public override void AI()
        {
            Player p = Main.player[projectile.owner];
            projectile.tileCollide = false;

            if (projectile.localAI[0] == 0f)
            {
                projectile.position = p.Center + new Vector2(0, -100f);
                projectile.localAI[1] = p.Center.Y;
                projectile.localAI[0]++;
            }

            Vector2 newVelocity = new Vector2(projectile.velocity.X, projectile.velocity.Y + p.gravity);
            if (projectile.position.Y > projectile.localAI[1] - projectile.height / 2)
            {
                newVelocity.Y *= bounce;
                projectile.position.Y = projectile.localAI[1] - projectile.height / 2;
                Main.PlaySound(SoundID.Dig, projectile.position);
            }
            projectile.velocity = newVelocity;
            projectile.rotation += spinRate * projectile.direction;
        }

        public override void Kill(int timeLeft)
        {
            for (int i = 0; i < 50; i++)
            {
                Dust.NewDust(projectile.position, projectile.width, projectile.height, 7);
            }
            Main.PlaySound(SoundID.Item14, projectile.position);
        }
        /*
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            projectile.velocity = new Vector2(oldVelocity.X, oldVelocity.Y * bounce);
            return false;
        }
        */
    }
}
