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

        public static void SetItemCheckState(CheckedListBox chb, string content, CheckState state)
        {
            for (int i = 0; i < chb.Items.Count; i++)
            {
                var valorDiaChb = chb.Items[i].ToString();
                var ehDiaDaSemanaJaChecado = valorDiaChb.Equals(content);
                if (ehDiaDaSemanaJaChecado)
                    chb.SetItemCheckState(i, state);
            }
        }

        public static void SetItemSelectListBox(ListBox lst, string content)
        {
            for (int i = 0; i < lst.Items.Count; i++)
            {
                var valorDiaChb = lst.Items[i].ToString();
                var ehDiaDaSemanaJaChecado = valorDiaChb.Equals(content);

                if (ehDiaDaSemanaJaChecado)
                    lst.SelectedIndex = i;
            }
        }

        public static int GetIdSelectedFromListBox(ListBox lst)
        {
            int.TryParse(lst.SelectedItem.ToString().Split("-")[0], out int codigo);
            return codigo;
        }
    }
}
