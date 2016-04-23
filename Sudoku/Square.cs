using System.Windows.Forms;

namespace Sudoku
{
    public partial class Square : UserControl
    {
        // Value of Square
        public int Value { get; set; }
        // FinalValue is Calculated Value by system before game commences to assert there is a possible solution.. 
        public int FinalValue { get; set; }


        public Square()
        {
            InitializeComponent();
        }
    }
}
