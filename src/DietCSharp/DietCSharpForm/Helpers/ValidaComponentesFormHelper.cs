using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietCSharpForm.Helpers
{
    public class ValidaComponentesFormHelper
    {
        public static bool ValidaERetornaIdDataGrid(DataGridView grid, out string mensagem, out int id)
        {
            mensagem = string.Empty;
            id = 0;
            if (grid.SelectedCells.Count <= 0)
            {
                mensagem = "Selecione um valor válido na lista para editar ou excluir.";
                return false;
            }

            if (!int.TryParse(grid.SelectedCells[0].Value.ToString(), out id))
            {
                mensagem = "Valor selecionado inválido!";
                return false;
            }

            return true;
        }

        public static List<int> GetIdCheckedListBoxCheckedItems(CheckedListBox chb)
        {
            List<int> list = new List<int>();
            foreach (var item in chb.CheckedItems)
            {
                int.TryParse(item.ToString().Split("-")[0], out int codigo);
                list.Add(codigo);
            }
            return list;
        }
    }
}
