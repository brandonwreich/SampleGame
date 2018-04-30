using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SampleGame.Model
{
	public class Player
	{
		private Texture2D playerTexture;
		public Texture2D PlayerTexture
		{
			get { return playerTexture; }
			set { playerTexture = value; }
		}

		public Vector2 Position;

		// State of player
		private bool active;
		public bool Active
		{
			get { return active; }
			set { active = value; }
		}

		// Amount of hit points the player has
		private int health;
		public int Health
		{
			get { return health; }
			set { health = value; }
		}

		// Get the width hof the player ship
		public int Width
		{
			get { return PlayerTexture.Width; }
		}


		public Player()
		{

		}

		public void Initialize(Texture2D texture, Vector2 position)
		{
			PlayerTexture = texture;

			// Set the starting position of the player around the middle of the screen
			Position = position;

			// Set the player to be active
			Active = true;

			// Set the player health
			Health = 100;
		}

		public void Update()
		{

		}

		public void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.Draw(PlayerTexture, Position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
		}

	}
}
