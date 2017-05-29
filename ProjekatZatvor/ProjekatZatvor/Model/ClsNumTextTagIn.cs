using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatZatvor.Model
{
    
  public class ClsNumTextTagIn
    {
        private class cTxtBoxProperty
        {
            public int iBeg { get; set; }
            public int iSel { get; set; }
            public int iLen { get; set; }
            public string sLef { get; set; }
            public string sRig { get; set; }
            public string sSel { get; set; }
            public string sTxt { get; set; }
            public cTxtBoxProperty(Windows.UI.Xaml.Controls.TextBox sender)
            {
                iBeg = sender.SelectionStart;
                iSel = sender.SelectionLength;
                iLen = sender.Text.Length;
                sLef = sender.Text.Substring(0, sender.SelectionStart);
                sRig = sender.Text.Substring(sender.SelectionStart + sender.SelectionLength);
                sSel = sender.SelectedText;
                sTxt = sender.Text;
            }
        }

        private cTxtBoxProperty org { get; set; }
        public string MyPattern { get; set; }
        public bool IsNumOnly { get; set; }
        public bool IsDotSepa { get; set; }
        public bool CanNegNum { get; set; }
        public System.Collections.Generic.List<string> LstRemStr { get; set; }
        public object Tag { get; set; } 

        public ClsNumTextTagIn()
        {
            
            MyPattern = "N2";
            IsNumOnly = true;
            IsDotSepa = true;
            CanNegNum = true;
            LstRemStr = new System.Collections.Generic.List<string>();
            
        }
        
        public ClsNumTextTagIn(Windows.UI.Xaml.Controls.TextBox sender, string pattern, bool numbersOnly, bool dotAsDecimalSeparator, bool allowNegativeNumbers, System.Collections.Generic.List<string> lstRemoveStrings, System.Object anyTag)
        {
            org = new cTxtBoxProperty(sender);
            MyPattern = pattern;
            IsNumOnly = numbersOnly;
            IsDotSepa = dotAsDecimalSeparator;
            CanNegNum = allowNegativeNumbers;
            LstRemStr = lstRemoveStrings;
            Tag = anyTag; 
        }
        public void Refresh(Windows.UI.Xaml.Controls.TextBox sender)
        {
            org = new cTxtBoxProperty(sender);
        }
        public void NumericText(Windows.UI.Xaml.Controls.TextBox sender)
        { 
            if (org == null)
            {
                org = new cTxtBoxProperty(sender);
            }

            System.Globalization.CultureInfo ci = System.Globalization.CultureInfo.CurrentUICulture;
            cTxtBoxProperty edi = new cTxtBoxProperty(sender);
            string sPtn = MyPattern;
            string sAdd = string.Empty;
            string sSub = string.Empty;
            int iChg = edi.iLen - org.iBeg - org.sRig.Length;

            if (iChg >= 0)
            {
                sAdd = edi.sTxt.Substring(org.iBeg, iChg);
                sSub = org.sSel;
            }
            else
            { 
                if (org.iLen >= edi.iLen)
                {
                    if (org.iBeg - (org.iLen - edi.iLen) >= 0)
                    {
                        sSub = org.sTxt.Substring(org.iBeg - (org.iLen - edi.iLen), (org.iLen - edi.iLen));
                    }
                }
            }

            int iBgx = edi.iBeg;
            int iSlx = 0;
            string sFnl = org.sTxt;

            int iNeg = sFnl.IndexOf(ci.NumberFormat.NegativeSign);
            int iDot = sFnl.IndexOf(ci.NumberFormat.NumberDecimalSeparator);

            if (sAdd == ci.NumberFormat.NegativeSign)
            {
                if (iNeg == -1)
                { 
                    if (CanNegNum)
                    {
                        sFnl = ci.NumberFormat.NegativeSign + sFnl;
                        iBgx = edi.iBeg;
                        //}
                    }
                    else
                    {
                        iBgx = edi.iBeg - ci.NumberFormat.NegativeSign.Length;
                     


                    }
                }
                else
                {//ukloni
                    sFnl = sFnl.Remove(iNeg, ci.NumberFormat.NegativeSign.Length);
                    if (iNeg >= iBgx)
                    {
                        iBgx = edi.iBeg - ci.NumberFormat.NegativeSign.Length;
                    }
                    else
                    {
                       
                        iBgx = edi.iBeg - ci.NumberFormat.NegativeSign.Length - ci.NumberFormat.NegativeSign.Length;
                        //}
                    }
                }
            } 
            else if (sAdd == ci.NumberFormat.NumberDecimalSeparator)
            { 
                if (iDot == -1)
                { //add
                    sFnl = edi.sTxt;
                }
                else
                { 
                    sFnl = org.sTxt;
                    iBgx = iDot + ci.NumberFormat.NumberDecimalSeparator.Length;
                }
            }
            else if (sAdd == ".")
            { 
                if (IsDotSepa)
                {
                    if (iDot == -1)
                    { 
                        sFnl = edi.sTxt;
                    }
                    else
                    { 
                        sFnl = org.sTxt;
                        iBgx = iDot + ci.NumberFormat.NumberDecimalSeparator.Length;
                    }
                }
                else
                {
                    sFnl = edi.sTxt; 
                }
            }
            else if (sSub == ci.NumberFormat.NumberGroupSeparator & org.iSel == 0)
            { 
                if (edi.iBeg == 0)
                {
                    sFnl = edi.sTxt;
                }
                else
                {
                    sFnl = edi.sLef.Replace(ci.NumberFormat.NumberGroupSeparator, string.Empty);
                    int iRem = edi.sLef.Length - sFnl.Length;
                    sFnl = sFnl.Substring(0, edi.sLef.Length - iRem - 1) + edi.sRig;
                    iBgx = iBgx - iRem - 1;
                }
            }
            else
            {
                sFnl = edi.sTxt;
            }

            if (iBgx > sFnl.Length)
            {
                iBgx = sFnl.Length;
            }
            string sLfx = sFnl.Substring(0, iBgx);
            string sRgx = sFnl.Substring(iBgx);

            sRgx = sRgx.Replace(ci.NumberFormat.NumberGroupSeparator, string.Empty);
            sFnl = sFnl.Replace(ci.NumberFormat.NumberGroupSeparator, string.Empty);

            if (LstRemStr != null)
            {
                foreach (string sRem in LstRemStr)
                {
                    sRgx = sRgx.Replace(sRem, string.Empty);
                    sFnl = sFnl.Replace(sRem, string.Empty); 
                }
            }

            

            if (!CanNegNum)
            {//izbrisi minus
                sRgx = sRgx.Replace(ci.NumberFormat.NegativeSign, string.Empty);
                sFnl = sFnl.Replace(ci.NumberFormat.NegativeSign, string.Empty);
            }

            decimal dFnl = decimal.Zero;
            decimal dRgx = decimal.Zero;
            if (decimal.TryParse(sFnl, out dFnl))
            {

                int iDtx = sFnl.IndexOf(ci.NumberFormat.NumberDecimalSeparator);
                int iDif = sFnl.Length - dFnl.ToString().Length;

                if (iDtx == -1)
                {
                    sFnl = dFnl.ToString(sPtn);
                    int iTmp = sFnl.IndexOf(ci.NumberFormat.NumberDecimalSeparator);
                    if (iTmp == -1)
                    {
                        if (sRgx == string.Empty)
                        {
                            iBgx = sFnl.Length;
                        }
                        else
                        {
                            if (sRgx.StartsWith(decimal.Zero.ToString()))
                            {
                                sRgx = decimal.One.ToString() + sRgx;
                                if (decimal.TryParse(sRgx, out dRgx))
                                {
                                    sRgx = dRgx.ToString(sPtn);
                                    if (sRgx.StartsWith(decimal.One.ToString() + ci.NumberFormat.NumberDecimalSeparator))
                                    {
                                        iBgx = sFnl.Length - sRgx.Length + (decimal.One.ToString() + ci.NumberFormat.NumberDecimalSeparator).Length;
                                    }
                                    else
                                    {
                                        iBgx = sFnl.Length - sRgx.Length + decimal.One.ToString().Length;
                                    }
                                }
                            }
                            else
                            {
                                if (decimal.TryParse(sRgx, out dRgx))
                                {
                                    sRgx = dRgx.ToString(sPtn);
                                    iBgx = sFnl.Length - sRgx.Length;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (sRgx == string.Empty)
                        {
                            iBgx = iTmp;
                        }
                        else
                        {
                            if (sRgx.StartsWith(decimal.Zero.ToString()))
                            {
                                sRgx = decimal.One.ToString() + sRgx;
                                if (decimal.TryParse(sRgx, out dRgx))
                                {
                                    sRgx = dRgx.ToString(sPtn);
                                    if (sRgx.StartsWith(decimal.One.ToString() + ci.NumberFormat.NumberDecimalSeparator))
                                    {
                                        iBgx = sFnl.Length - sRgx.Length + (decimal.One.ToString() + ci.NumberFormat.NumberDecimalSeparator).Length;
                                    }
                                    else
                                    {
                                        iBgx = sFnl.Length - sRgx.Length + decimal.One.ToString().Length;
                                    }
                                }
                            }
                            else
                            {
                                if (decimal.TryParse(sRgx, out dRgx))
                                {
                                    sRgx = dRgx.ToString(sPtn);
                                    iBgx = sFnl.Length - sRgx.Length;
                                }
                            }
                        }
                    }
                    if (iBgx < 0)
                    {
                        iBgx = 0;
                    }
                }
                else
                {
                    if (sFnl.Length - sRgx.Length <= iDtx)
                    {
                        sFnl = dFnl.ToString(sPtn);
                        if (sRgx.StartsWith(decimal.Zero.ToString()))
                        {
                            sRgx = decimal.One.ToString() + sRgx;
                            if (decimal.TryParse(sRgx, out dRgx))
                            {
                                sRgx = dRgx.ToString(sPtn);
                                if (sRgx.StartsWith(decimal.One.ToString() + ci.NumberFormat.NumberDecimalSeparator))
                                {
                                    iBgx = sFnl.Length - sRgx.Length + (decimal.One.ToString() + ci.NumberFormat.NumberDecimalSeparator).Length;
                                }
                                else
                                {
                                    iBgx = sFnl.Length - sRgx.Length + decimal.One.ToString().Length;
                                }
                            }
                        }
                        else if (sRgx.StartsWith(ci.NumberFormat.NumberDecimalSeparator))
                        {
                            if (decimal.TryParse(sRgx, out dRgx))
                            {
                                sRgx = dRgx.ToString(sPtn);
                                iBgx = sFnl.Length - sRgx.Length + ci.NumberFormat.NumberDecimalSeparator.Length;
                            }
                        }
                        else
                        {
                            if (decimal.TryParse(sRgx, out dRgx))
                            {
                                sRgx = dRgx.ToString(sPtn);
                                iBgx = sFnl.Length - sRgx.Length;
                            }
                        }

                        if (iBgx < 0)
                        {
                            iBgx = 0;
                        }
                    }
                    else
                    {
                        sFnl = dFnl.ToString(sPtn);
                        int iTmp = sFnl.IndexOf(ci.NumberFormat.NumberDecimalSeparator); 
                        if (iTmp == -1)
                        {
                            iBgx = sFnl.Length;
                        }
                        else
                        {
                            if (sSub != string.Empty & sAdd == string.Empty)
                            {
                                if (iTmp + 1 < iBgx)
                                {
                                    iBgx = iBgx - 1;
                                }
                                else
                                {
                                    iBgx = iTmp;
                                }
                            }

                            if (sFnl.Length > iBgx)
                            {
                                if (iBgx > iTmp)
                                {
                                    iSlx = 1;
                                }
                            }
                        }
                    }
                }
                sender.Text = sFnl;
                sender.SelectionStart = iBgx;
                sender.SelectionLength = iSlx;
            }
            else
            {
                if (IsNumOnly)
                { 
                    decimal dOrg = decimal.Zero;
                    if (sFnl != string.Empty && decimal.TryParse(org.sTxt, out dOrg))
                    {
                        sender.Text = org.sTxt;
                        sender.SelectionStart = org.iBeg;
                        sender.SelectionLength = org.iSel;
                    }
                    else
                    {
                        decimal dAdd = decimal.Zero;
                        decimal.TryParse(sAdd, out dAdd);
                        sFnl = dAdd.ToString(sPtn);
                        int iTmp = sFnl.IndexOf(ci.NumberFormat.NumberDecimalSeparator);

                        if (iTmp == -1)
                        {
                            iBgx = sFnl.Length;
                        }
                        else
                        {
                            iBgx = iTmp;
                        }
                        sender.Text = sFnl;
                        sender.SelectionStart = iBgx;
                        sender.SelectionLength = 0;
                    }
                }
                else
                { 
                    sender.Text = edi.sTxt;
                    sender.SelectionStart = edi.iBeg;
                    sender.SelectionLength = edi.iSel;
                }
            }
        }
    }
}
