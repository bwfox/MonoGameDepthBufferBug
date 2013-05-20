using Microsoft.Xna.Framework;


namespace Graphics3DSample
{
    /// <summary>
    /// A game component.
    /// Has an associated rectangle.
    /// Accepts touch and click inside the rectangle.
    /// Has a state of IsTouching and IsClicked.
    /// </summary>
    public class Clickable : DrawableGameComponent
    {

        #region Fields
        readonly Rectangle rectangle;
        bool wasTouching;
        bool isTouching;

        #region Protected accessors
        public bool IsTouching { get { return isTouching; } }
        public bool IsClicked { get { return (wasTouching == true) && (isTouching == false); } }

        protected Rectangle Rectangle { get { return rectangle; } }
        protected new Graphics3DSampleGame Game { get { return (Graphics3DSampleGame)base.Game; } }
        #endregion
        #endregion

        #region Initialization
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="game">The Game oject</param>
        /// <param name="targetRectangle">Position of the component on the screen</param>
        public Clickable(Graphics3DSampleGame game, Rectangle targetRectangle)
            : base(game)
        {
            rectangle = targetRectangle;
        }
        #endregion

        #region Input handling
        /// <summary>
        /// Handles Input
        /// </summary>
        protected void HandleInput()
        {

        }
        #endregion
    }
}


