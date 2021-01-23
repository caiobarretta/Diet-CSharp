using Core.Entities.Base;
using DietCSharpForm.DTO.Base;
using DietCSharpForm.Interfaces.Componente.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietCSharpForm.Services.Componente.Base
{
    public class DefaultComponenteService<TEntity> : IDefaultService<TEntity> where TEntity : Entity
    {
        public virtual void ConfigureGridSearch(DataGridView dataGridView, ICollection<TEntity> entities)
        {

            dataGridView.Columns.AddRange(new DataGridViewColumn[] {
                new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "ID",
                    HeaderText = "Código",
                    Name = "ID",
                    ReadOnly = true
                },

                new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Nome",
                    HeaderText = "Nome",
                    Name = "Nome",
                    ReadOnly = true
                },
                new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Descricao",
                    HeaderText = "Descrição",
                    Name = "Descricao",
                    ReadOnly = true
                }
            });

            List<DTOGridDefault> list = new List<DTOGridDefault>();

            foreach (var entity in entities)
            {
                list.Add(
                    new DTOGridDefault()
                    {
                        ID = entity.ID,
                        Nome = entity.Nome,
                        Descricao = entity.Descricao
                    });
            }

            dataGridView.DataSource = list;
        }
    }
}
