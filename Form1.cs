using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GereOficina
{
    public partial class frmGereOficina : Form
    {
        private MinhaOficinaContainer db;

        public frmGereOficina()
        {
            InitializeComponent();
        }

        private void frmGereClientes_Load(object sender, EventArgs e)
        {
            db = new MinhaOficinaContainer();
            lerClientes();
        }

        private void lerClientes()
        {

            lbLC_Clientes.DataSource = null;
            lbLC_Clientes.DataSource = db.Clientes.ToList<Cliente>();

            if (lbLC_Clientes.SelectedIndex == -1)
            {
                lbLC_Clientes.DataSource = null;
            }
            else
            {
                Cliente clienteSelecionado = (Cliente)lbLC_Clientes.SelectedItem;
                lblFCS_TotalGasto.Text = clienteSelecionado.totalGasto().ToString();

                lerCarros();
            }
           
        }

        private void btnLC_AddCliente_Click(object sender, EventArgs e)
        {
            db.Clientes.Add(new Cliente(txtLC_NomeCliente.Text, txtLC_NIFCliente.Text));
            db.SaveChanges();
            lerClientes();
            lbLC_Clientes.SelectedIndex = db.Clientes.Count() - 1;
            txtLC_NomeCliente.Text = "";
            txtLC_NIFCliente.Text = "";
        }

        private void lbLC_Clientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbLC_Clientes.SelectedIndex != -1)
            {
                Cliente clienteSelecionado = (Cliente)lbLC_Clientes.SelectedItem;
                txtFCS_NomeCLiente.Text = clienteSelecionado.Nome;
                txtFCS_NIFCliente.Text = clienteSelecionado.NIF;
                lblFCS_TotalGasto.Text = clienteSelecionado.totalGasto().ToString();
                lerCarros();
            }
            
        }



        private void lerCarros()
        {
             if(lbLC_Clientes.SelectedIndex > -1)
            {
                lbFCS_Carros.DataSource = null;
                Cliente clienteSelecionado = (Cliente)lbLC_Clientes.SelectedItem;
                lbFCS_Carros.DataSource = clienteSelecionado.Carros.ToList<Carro>();
                lerServicos();

            }
            else
            {
                lbFCS_Carros.DataSource = null;
            }
            
        }

        private void btnFCS_AddCarro_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)lbLC_Clientes.SelectedItem;
            clienteSelecionado.Carros.Add(new Carro(txtFCS_MatriculaCarro.Text));
            db.SaveChanges();
            lerClientes();
            lbLC_Clientes.SelectedItem = clienteSelecionado;
            lbFCS_Carros.SelectedIndex = clienteSelecionado.Carros.Count() - 1;
            txtFCS_MatriculaCarro.Text = "";
        }

        private void lbFCS_Carros_SelectedIndexChanged(object sender, EventArgs e)
        {
            lerServicos();
        }

        private void lerServicos()
        {
            if(lbFCS_Carros.SelectedIndex > -1)
            {
                lbFCS_Servicos.DataSource = null;
                Carro carroSelecionado = (Carro)lbFCS_Carros.SelectedItem;
                lbFCS_Servicos.DataSource = carroSelecionado.Servicos.ToList<Servico>();
                lerParcelas();
            }
            else
            {
                lbFCS_Servicos.DataSource = null;
            }
            
        }


        private void btnFCS_AddServico_Click(object sender, EventArgs e)
        {
            Carro carroSelecionado = (Carro)lbFCS_Carros.SelectedItem;
            carroSelecionado.Servicos.Add(new Servico((String)cboFCS_Tipo.SelectedItem));
            db.SaveChanges();
            lerCarros();
            lbFCS_Carros.SelectedItem = carroSelecionado;
            lbFCS_Servicos.SelectedIndex = carroSelecionado.Servicos.Count() - 1;

            cboFCS_Tipo.SelectedIndex = -1;


        }

        private void lbFCS_Servicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            lerParcelas();
         

        }

        private void lerParcelas()
        {
            if(lbFCS_Servicos.SelectedIndex > -1)
            {
                lbFCS_Parcelas.DataSource = null;
                Servico servicoSelecionado = (Servico)lbFCS_Servicos.SelectedItem;
                lbFCS_Parcelas.DataSource = servicoSelecionado.Parcelas.ToList<Parcela>();
            }
            else
            {
                lbFCS_Parcelas.DataSource = null;
            }
        }

        private void btnFCS_AddParcela_Click(object sender, EventArgs e)
        {
            Servico servicoSelecionado = (Servico)lbFCS_Servicos.SelectedItem;
            servicoSelecionado.Parcelas.Add(new Parcela(txtFCS_Descricao.Text, Double.Parse(txtFCS_Valor.Text)));
            db.SaveChanges();
            
            txtFCS_Descricao.Text = "";
            txtFCS_Valor.Text = "";

            Carro carroSelecionado = (Carro)lbFCS_Carros.SelectedItem;
            Cliente clienteSelecionado = (Cliente)lbLC_Clientes.SelectedItem;
            lerClientes();
            lbFCS_Carros.SelectedItem = carroSelecionado;
            lbLC_Clientes.SelectedItem = clienteSelecionado;

            lbFCS_Servicos.SelectedItem = servicoSelecionado;
            lbFCS_Parcelas.SelectedIndex = servicoSelecionado.Parcelas.Count() - 1;
  
            
        }

        private void btnFCS_Guardar_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)lbLC_Clientes.SelectedItem;
            clienteSelecionado.Nome = txtFCS_NomeCLiente.Text;
            clienteSelecionado.NIF = txtFCS_NIFCliente.Text;
            db.SaveChanges();
            lerClientes();
        }

        private void btnFCS_RemoveParcela_Click(object sender, EventArgs e)
        {
            if(lbFCS_Parcelas.SelectedIndex != -1)
            {
                Parcela parcelaSelecionada = (Parcela)lbFCS_Parcelas.SelectedValue;
                db.Parcelas.Remove(parcelaSelecionada);
                db.SaveChanges();
                int indexServicos = lbFCS_Servicos.SelectedIndex;
                int indexCarros = lbFCS_Carros.SelectedIndex;
                int indexClientes = lbLC_Clientes.SelectedIndex;
                lerClientes();
                lbFCS_Servicos.SelectedIndex = indexServicos;
                lbFCS_Carros.SelectedIndex = indexCarros;
                lbLC_Clientes.SelectedIndex = indexClientes;
            }
            
        }

        private void btnFCS_RemoveServico_Click(object sender, EventArgs e)
        {
            if(lbFCS_Servicos.SelectedIndex != -1)
            {
                Servico servicoSelecionado = (Servico)lbFCS_Servicos.SelectedValue;
                
                foreach(Parcela parcela in servicoSelecionado.Parcelas.ToList<Parcela>())
                {
                    db.Parcelas.Remove(parcela);
                }
                db.Servicos.Remove(servicoSelecionado);
                db.SaveChanges();
                int indexCarros = lbFCS_Carros.SelectedIndex;
                int indexClientes = lbLC_Clientes.SelectedIndex;
                lerClientes();
                lbFCS_Carros.SelectedIndex = indexCarros;
                lbLC_Clientes.SelectedIndex = indexClientes;
            }
        }

        private void btnFCS_RemoveCarro_Click(object sender, EventArgs e)
        {
            if(lbFCS_Carros.SelectedIndex != -1)
            {
                Carro carroSelecionado = (Carro)lbFCS_Carros.SelectedItem;
               

                foreach (Servico servico in carroSelecionado.Servicos.ToList<Servico>())
                {
                    foreach(Parcela parcela in servico.Parcelas.ToList<Parcela>())
                    {
                        db.Parcelas.Remove(parcela);
                    }
                    db.Servicos.Remove(servico);
                }
                db.Carros.Remove(carroSelecionado);
                db.SaveChanges();
                int indexClientes = lbLC_Clientes.SelectedIndex;
                lerClientes();
                lbLC_Clientes.SelectedIndex = indexClientes;
            }
        }

        private void btnLC_RemoveCliente_Click(object sender, EventArgs e)
        {
            if(lbLC_Clientes.SelectedIndex != -1)
            {
                Cliente clienteSelecionado = lbLC_Clientes.SelectedItem as Cliente;
                foreach(Carro carro in clienteSelecionado.Carros.ToList<Carro>())
                {
                    foreach(Servico servico in carro.Servicos.ToList<Servico>())
                    {
                        foreach(Parcela parcela in servico.Parcelas.ToList<Parcela>())
                        {
                            db.Parcelas.Remove(parcela);
                        }
                        db.Servicos.Remove(servico);
                    }
                    db.Carros.Remove(carro);
                }
                db.Clientes.Remove(clienteSelecionado);
                db.SaveChanges();
                lerClientes();
            }
        }
    }
}
