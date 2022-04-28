using System.Linq;
using System.Windows.Forms;
using Library.Data;

namespace Di.Forms
{
    public partial class MainForm : Form
    {
        private readonly LibraryContext _context;

        public MainForm(LibraryContext context)
        {
            _context = context;
            InitializeComponent();

            InitializeBooks();
        }

        private void InitializeBooks()
        {
            BooksDataGridView.DataSource = _context.Books.ToList();
        }
    }
}
