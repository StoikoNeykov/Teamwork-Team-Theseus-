﻿namespace GameLogic.Models
{
    using Enumerations;
    using Interfaces;

    /// <summary>
    /// All kind of ingame blocks
    /// </summary>
    public abstract class Block : GameElement, IBlock, IGameElement
    {
        #region fields

        private short top;

        private short left;

        private bool[,] shape;

        #endregion

        #region Constructors

        public Block(short width, short height, short top, short left, FigureForms shape)
            : base(width, height)
        {
            this.Top = top;
            this.Left = left;
            // this.Shape = GetShape(shape);
        }

        #endregion

        //TODO validations 
        #region Properties


        public short Top
        {
            get
            {
                return this.top;
            }
            set
            {
                this.top = value;
            }
        }

        public short Left
        {
            get
            {
                return this.left;
            }
            set
            {
                this.left = value;
            }
        }

        // realonly for now 
        public bool[,] Shape
        {
            get
            {
                return this.shape;
            }
            private set
            {
                this.shape = value;
            }
        }

        public GlobalConstant Density { get; private set; }

        #endregion

        //TODO add shapes in cases
        #region Private Methods

        // private bool[,] GetShape(FigureForms shape)
        // {
        //     bool[,] result;
        //     switch (shape)
        //     {
        //         case 1:
        //         case 2:
        //         case 3:
        //
        //         default:
        //             break;
        //     }
        //
        //     return result;
        // }

        #endregion
    }

}
