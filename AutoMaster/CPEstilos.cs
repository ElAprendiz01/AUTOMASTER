using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoMaster
{
    public class CPEstilos
    {
        public static void AplicarEstilosProfesionales(DataGridView dgv)
        {
            // 1. Configuración Básica del DataGridView
            dgv.AllowUserToAddRows = false;        // No permitir añadir filas directamente
            dgv.AllowUserToDeleteRows = false;     // No permitir borrar filas directamente
            dgv.ReadOnly = true;                   // Hacer la grilla de solo lectura
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleccionar toda la fila
            dgv.MultiSelect = false;               // No permitir selección múltiple
            dgv.BorderStyle = BorderStyle.None;    // Eliminar el borde exterior del control

            // 2. Estilo de los Encabezados de Columna
            dgv.EnableHeadersVisualStyles = false; // Permitir estilos personalizados en los encabezados
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None; // Eliminar bordes de encabezado
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 76); // Fondo oscuro
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;             // Texto blanco
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold); // Fuente negrita
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft; // Alineación
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                //para que se adapte uno a uno 
               col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            // Texto del encabezado centralizado
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            //  Ajustar la altura de los encabezados al contenido si el texto es largo
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            //   Texto de las celdas centrado
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //Texto de las celdas alternas centrado (para consistencia)
            dgv.AlternatingRowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // 3. Estilo por defecto de las celdas
            dgv.DefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249); // Fondo claro para filas normales
            dgv.DefaultCellStyle.ForeColor = Color.Black;                     // Texto oscuro
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9);              // Fuente estándar

            // 4. Colores de Filas Alternos (Banding)
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224); // Fondo gris más oscuro para filas alternas

            // 5. Estilo de Celda al Seleccionar
            dgv.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue; // Fondo azul claro al seleccionar
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;          // Texto oscuro al seleccionar

            // 6. Bordes de las Celdas Internas (Horizontalmente)
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal; // Solo bordes horizontales
            dgv.GridColor = Color.LightGray; // Color del borde de la grilla

            // 7. Eliminar la columna de encabezado de fila (el cuadrito a la izquierda)
            dgv.RowHeadersVisible = false;

       
            // AllCells: Las columnas se ajustan al contenido más largo de cada celda.
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            
            dgv.RowTemplate.Height = 25; // Altura estándar para filas
        }
    }
}
