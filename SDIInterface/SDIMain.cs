using SDIInterface.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SDIInterface
{
    public partial class SDIMain : Form
    {
        public SDIMain()
        {
            InitializeComponent();
            //  Inicializa Barra de ferramentas
            ToolStripConfig();
        }

        private void ToolStripConfig()
        {
            // Create a new ToolStrip control.
            ToolStrip tlsAction = new ToolStrip
            {
                Margin = new Padding(0, 5, 0, 1),
                Dock = DockStyle.Top,
                GripMargin = new Padding(5, 8, 8, 3),
                BackColor = Color.Silver
            };
            this.Controls.Add(tlsAction);  // Add the ToolStrip control to the Form Controls collection.

            tlsAction.Items.Clear();

            ToolStripButton tstNewRecord = new ToolStripButton()
            {
                Image = Resources.newRecord32,
                BackColor = Color.Silver,
                ToolTipText = "Add new record"
            };
            tstNewRecord.Click += (object sender, EventArgs e) =>     // Funcao aionada pelo CLICK no button  
            {
                Form frm1 = new Form1();
                frm1.Show();
            };
            tlsAction.Items.Add(tstNewRecord);

            ToolStripButton tstRefresh = new ToolStripButton
            {
                Image = Resources.undo32,
                ToolTipText = "Restore current record"
            };
            tstRefresh.Click += (object sender, EventArgs e) =>     // Funcao aionada pelo CLICK no button  
            {
                Form frm2 = new Form2();
                frm2.Show();
            };
            tlsAction.Items.Add(tstRefresh);

            tlsAction.Items.Add(new ToolStripSeparator { AutoSize = false, Width = 6 });

            ToolStripButton tstDelete = new ToolStripButton
            {
                Image = Resources.delete32,
                ToolTipText = "Delete current record"
            };
            tstDelete.Click += (object sender, EventArgs e) =>     // Funcao aionada pelo CLICK no button  
            {
                Form frm3 = new Form3();
                frm3.Show();
            };
            tlsAction.Items.Add(tstDelete);

            tlsAction.Items.Add(new ToolStripSeparator { AutoSize = false, Height = 32, Width = 12 });

            ToolStripLabel tslSearch = new ToolStripLabel
            {
                Font = new Font("Arial", 11),
                ForeColor = Color.Navy,
                Text = "Search"
            };
            tlsAction.Items.Add(tslSearch);

            tlsAction.Items.Add(new ToolStripSeparator { AutoSize = false, Width = 12 });

            //  ------------------------------Drop Down Button (DDB) - Inicio ------------------------------------------------------
            //  Vamos incluir um drop down button com uma lista de de duas opcoes por exemplo:
            //
            //      DropDownButtom
            //            |-----------> Drop Opcao "A"  
            //            |-----------> Drop Opcao "B" 
            //
            //  Para definir um drop down button (DDB) como neste no exemplo abaixo recomendo o seguinte:
            //
            //  1.  Definir is itens de menu 'Opcao "A" ' e 'Opcao "B" '   ----->   (linhas comentadas //** opcao A e //** opcao B)
            //
            //  2.  Definir o drop down button que vai conter as duas opcoes --->   (linha comentada   //* Instancia o Drop Down Button
            //
            //  3.  Adiciona os itens de menu a collection de DropDownItems do DDB  (linha comentada   //* Add to Button collection
            //
            //  4.  Finalmente adiciona o DropDownButton a ToolStrip controls collection ( linha       //* Add DDB to ToolStrip  
            //

            ToolStripMenuItem tstDropMnuItemOptionA = new ToolStripMenuItem     //* opcao A 
            {
                Checked = true,
                Text = "Barra de Menu"
            };
            tstDropMnuItemOptionA.Click += (object sender, EventArgs e) =>
            {
                //mainMnuStrip.Visible = !mainMnuStrip.Visible;
                tstDropMnuItemOptionA.Checked = !tstDropMnuItemOptionA.Checked;
            };

            ToolStripMenuItem tstDropMnuItemOptionB = new ToolStripMenuItem     //* opcao B
            {
                Image = Resources.delete32,
                Text = "OptionDrop B"
            };
            //tstDropMnuItemOptionB.Click += TstDropMnuItemOption_Click;            //  Define qual a funcao que vai tratar o evento CLICK

            ToolStripDropDownButton tstDropBtn = new ToolStripDropDownButton        //* Instancia o Drop Down Button
            {
                Image = Resources.newRecord32,
                ForeColor = Color.Navy,
                Text = "Drop"
            };
            //tstDropBtn.Click += TstDropBtn_Click;
            tstDropBtn.DropDownItems.Add(tstDropMnuItemOptionA);                    //* Add to DropDownItems collection
            tstDropBtn.DropDownItems.Add(tstDropMnuItemOptionB);                    //* Add to DropDownItems collection
            tlsAction.Items.Add(tstDropBtn);                                        //* Add DDB to ToolStrip  

            // ---------------------------------Drop Down Button (DDB) - final --------------------------------------------------------


            // -------------------------------- Split Button ( SpltBt) - Inicio  ------------------------------------------------------

            ToolStripSplitButton tstSplitBtn = new ToolStripSplitButton
            {
                Image = Resources.newRecord32,
                ForeColor = Color.Navy,
                Text = "Split"
            };            
          
            tlsAction.Items.Add(tstSplitBtn);

            // -------------------------------- Split Button ( SpltBt) - Final  ------------------------------------------------------
        }
    }
}
