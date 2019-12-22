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
    /// Implements the ExdDataFieldConfiguration profile message.
    /// </summary>
    public class ExdDataFieldConfigurationMesg : Mesg
    {
        #region Fields
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="ExdDataFieldConfigurationMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte ScreenIndex = 0;
            public const byte ConceptField = 1;
            public const byte FieldId = 2;
            public const byte ConceptCount = 3;
            public const byte DisplayType = 4;
            public const byte Title = 5;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public ExdDataFieldConfigurationMesg() : base(Profile.GetMesg(MesgNum.ExdDataFieldConfiguration))
        {
        }

        public ExdDataFieldConfigurationMesg(Mesg mesg) : base(mesg)
        {
        }
        #endregion // Constructors

        #region Methods
        ///<summary>
        /// Retrieves the ScreenIndex field</summary>
        /// <returns>Returns nullable byte representing the ScreenIndex field</returns>
        public byte? GetScreenIndex()
        {
            Object val = GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set ScreenIndex field</summary>
        /// <param name="screenIndex_">Nullable field value to be set</param>
        public void SetScreenIndex(byte? screenIndex_)
        {
            SetFieldValue(0, 0, screenIndex_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the ConceptField field</summary>
        /// <returns>Returns nullable byte representing the ConceptField field</returns>
        public byte? GetConceptField()
        {
            Object val = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set ConceptField field</summary>
        /// <param name="conceptField_">Nullable field value to be set</param>
        public void SetConceptField(byte? conceptField_)
        {
            SetFieldValue(1, 0, conceptField_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the FieldId field</summary>
        /// <returns>Returns nullable byte representing the FieldId field</returns>
        public byte? GetFieldId()
        {
            Object val = GetFieldValue(2, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set FieldId field</summary>
        /// <param name="fieldId_">Nullable field value to be set</param>
        public void SetFieldId(byte? fieldId_)
        {
            SetFieldValue(2, 0, fieldId_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the ConceptCount field</summary>
        /// <returns>Returns nullable byte representing the ConceptCount field</returns>
        public byte? GetConceptCount()
        {
            Object val = GetFieldValue(3, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set ConceptCount field</summary>
        /// <param name="conceptCount_">Nullable field value to be set</param>
        public void SetConceptCount(byte? conceptCount_)
        {
            SetFieldValue(3, 0, conceptCount_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the DisplayType field</summary>
        /// <returns>Returns nullable ExdDisplayType enum representing the DisplayType field</returns>
        public ExdDisplayType? GetDisplayType()
        {
            object obj = GetFieldValue(4, 0, Fit.SubfieldIndexMainField);
            ExdDisplayType? value = obj == null ? (ExdDisplayType?)null : (ExdDisplayType)obj;
            return value;
        }

        /// <summary>
        /// Set DisplayType field</summary>
        /// <param name="displayType_">Nullable field value to be set</param>
        public void SetDisplayType(ExdDisplayType? displayType_)
        {
            SetFieldValue(4, 0, displayType_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field Title</returns>
        public int GetNumTitle()
        {
            return GetNumFieldValues(5, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the Title field</summary>
        /// <param name="index">0 based index of Title element to retrieve</param>
        /// <returns>Returns byte[] representing the Title field</returns>
        public byte[] GetTitle(int index)
        {
            byte[] data = (byte[])GetFieldValue(5, index, Fit.SubfieldIndexMainField);
            return data.Take(data.Length - 1).ToArray();
        }

        ///<summary>
        /// Retrieves the Title field</summary>
        /// <param name="index">0 based index of Title element to retrieve</param>
        /// <returns>Returns String representing the Title field</returns>
        public String GetTitleAsString(int index)
        {
            byte[] data = (byte[])GetFieldValue(5, index, Fit.SubfieldIndexMainField);
            return data != null ? Encoding.UTF8.GetString(data, 0, data.Length - 1) : null;
        }

        ///<summary>
        /// Set Title field</summary>
        /// <param name="index">0 based index of Title element to retrieve</param>
        /// <param name="title_"> field value to be set</param>
        public void SetTitle(int index, String title_)
        {
            byte[] data = Encoding.UTF8.GetBytes(title_);
            byte[] zdata = new byte[data.Length + 1];
            data.CopyTo(zdata, 0);
            SetFieldValue(5, index, zdata, Fit.SubfieldIndexMainField);
        }

        
        /// <summary>
        /// Set Title field</summary>
        /// <param name="index">0 based index of title</param>
        /// <param name="title_">field value to be set</param>
        public void SetTitle(int index, byte[] title_)
        {
            SetFieldValue(5, index, title_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace
