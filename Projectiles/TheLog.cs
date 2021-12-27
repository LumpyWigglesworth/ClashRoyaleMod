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
        float duration = 180f;
        public override void SetDefaults()
        {
            projectile.width = 60;
            projectile.height = 60;
            projectile.penetrate = -1;
            projectile.magic = true;
            projectile.hostile = false;
            projectile.friendly = true;
            projectile.tileCollide = false;
            projectile.ignoreWater = false;
        }
        public override void AI()
        {
            Player p = Main.player[projectile.owner];

            if (projectile.localAI[0] >= duration)
                projectile.Kill();

            if (projectile.localAI[0] == 0f)
                projectile.localAI[1] = p.Center.X + p.height / 2;

            Vector2 lateralVelocity = new Vector2(10, 0);
            Vector2 gravity = new Vector2(0, p.gravity);
        }
        public override bool? CanCutTiles()
        {
            return true;
        }

    }
}
