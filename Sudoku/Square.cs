using System;
using System.Collections;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Square : UserControl, IEnumerator
    {
        // Value of Square
        public int? Value { get; set; }


        // FinalVaue is Calculated Value by system before game commences to assert there is a possible solution.. 
        public int? FinalValue { get; set; }


        public Square()
        {
            InitializeComponent();
        }


        public void SetFinalValue()
        {
            if(FinalValue!=null || FinalValue!=0)
                tbValue.Text = FinalValue.ToString();
        }
        object IEnumerator.Current
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        bool IEnumerator.MoveNext()
        {
            throw new NotImplementedException();
        }
        void IEnumerator.Reset()
        {
            throw new NotImplementedException();
        }
    }
}
