#region Copyright
////////////////////////////////////////////////////////////////////////////////
// The following FIT Protocol software provided may be used with FIT protocol
// devices only and remains the copyrighted property of Garmin Canada Inc.
// The software is being provided on an "as-is" basis and as an accommodation,
// and therefore all warranties, representations, or guarantees of any kind
// (whether express, implied or statutory) including, without limitation,
// warranties of merchantability, non-infringement, or fitness for a particular
// purpose, are specifically disclaimed.
//
// Copyright 2019 Garmin Canada Inc.
////////////////////////////////////////////////////////////////////////////////
// ****WARNING****  This file is auto-generated!  Do NOT edit this file.
// Profile Version = 21.20Release
// Tag = production/akw/21.20.00-0-g5907bff
////////////////////////////////////////////////////////////////////////////////

#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.IO;
using System.Linq;

namespace fitsharplib.Fit
{
    /// <summary>
    /// Implements the Pad profile message.
    /// </summary>
    public class PadMesg : Mesg
    {
        #region Fields
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="PadMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public PadMesg() : base(Profile.GetMesg(MesgNum.Pad))
        {
        }

        public PadMesg(Mesg mesg) : base(mesg)
        {
        }
        #endregion // Constructors

        #region Methods
        #endregion // Methods
    } // Class
} // namespace
