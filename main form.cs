using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using static Azure.Core.HttpHeader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Azure;

namespace pc_build
{
    public partial class main_form : UserControl
    {

        string connection_string = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True";
        bool cpu_selection = false, mobo_selection = false, pc_case_selection = false, ram_selection = false;
        int price_selection;
        string gpu_query, cpu_query, mobo_query, pc_case_query, hdd_query, ram_query, psu_query, ssd_query;
        SqlConnection gpu_con, mobo_con, cpu_con, ram_con, pc_case_con, hdd_con, ssd_con, psu_con, cpu_cooler_con;
        SqlCommand gpu_command, mobo_command, cpu_command, pc_case_command, hdd_command, ssd_command, psu_command, ram_command;
        SqlDataReader gpu_reader, mobo_reader, cpu_reader, pc_case_reader, ram_reader, ssd_reader, hdd_reader, psu_reader;

        public main_form()
        {
            InitializeComponent();
            price_combobox.SelectedIndex = 0;
            cpu_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            mobo_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            gpu_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            ram_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            psu_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            case_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            cpu_cooler_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            price_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            mobo_combobox.DropDownWidth = 400;
            case_combobox.DropDownWidth = 400;

        }

        public void gpu_list()
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void main_form_Load(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cpu_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gpu_line1()
        {
            gpu_combobox.Items.Clear();
            cpu_combobox.Items.Clear();
            cpu_cooler_combobox.Items.Clear();
            gpu_con = new SqlConnection(connection_string);
            gpu_con.Open();
        }

        private void gpu_line2()
        {
            gpu_command = new SqlCommand(gpu_query, gpu_con);
            gpu_reader = gpu_command.ExecuteReader();
            while (gpu_reader.Read())
            {
                string gpu_manufacturer = gpu_reader["gpu_manufacturer"].ToString();
                string gpu_model = gpu_reader["gpu_model"].ToString();
                gpu_combobox.Items.Add($"{gpu_manufacturer} {gpu_model}");
            }
            gpu_reader.Close();
        }

        private void cpu_line1()
        {
            cpu_combobox.Items.Clear();
            cpu_combobox.Items.Clear();
            cpu_con = new SqlConnection(connection_string);
            cpu_con.Open();
        }

        private void cpu_line2()
        {
            cpu_command = new SqlCommand(cpu_query, cpu_con);
            cpu_reader = cpu_command.ExecuteReader();
            while (cpu_reader.Read())
            {
                string cpu_manufacturer = cpu_reader["cpu_manufacturer"].ToString();
                string cpu_model = cpu_reader["cpu_name"].ToString();
                cpu_combobox.Items.Add($"{cpu_manufacturer} {cpu_model}");
            }
            cpu_reader.Close();
        }

        private void mobo_line1()
        {
            mobo_combobox.Items.Clear();
            mobo_combobox.Items.Clear();
            mobo_con = new SqlConnection(connection_string);
            mobo_con.Open();
        }

        private void mobo_line2()
        {
            mobo_command = new SqlCommand(mobo_query, mobo_con);
            mobo_reader = mobo_command.ExecuteReader();
            while (mobo_reader.Read())
            {
                string mobo_manufacturer = mobo_reader["mobo_manufacturer"].ToString();
                string mobo_name = mobo_reader["mobo_name"].ToString();
                string mobo_chipset = mobo_reader["mobo_chipset"].ToString();
                mobo_combobox.Items.Add($"{mobo_name} {mobo_chipset}");
            }
            mobo_reader.Close();
        }

        private void ram_line1()
        {
            ram_combobox.Items.Clear();
            ram_combobox.Items.Clear();
            ram_con = new SqlConnection(connection_string);
            ram_con.Open();

        }

        private void ram_line2()
        {
            ram_command = new SqlCommand(ram_query, ram_con);
            ram_reader = ram_command.ExecuteReader();
            while (ram_reader.Read())
            {
                string ram_manufacturer = ram_reader["ram_manufacturer"].ToString();
                string ram_name = ram_reader["ram_name"].ToString();
                string ram_type = ram_reader["ram_type"].ToString();
                string ram_capacity = ram_reader["ram_capacity"].ToString();
                ram_combobox.Items.Add($"{ram_manufacturer} {ram_name} {ram_type} {ram_capacity}");
            }
            ram_reader.Close();
        }

        private void psu_line1()
        {
            psu_combobox.Items.Clear();
            psu_combobox.Items.Clear();
            psu_con = new SqlConnection(connection_string);
            psu_con.Open();

        }

        private void psu_line2()
        {
            psu_command = new SqlCommand(psu_query, psu_con);
            psu_reader = psu_command.ExecuteReader();
            while (psu_reader.Read())
            {
                string psu_manufacturer = psu_reader["psu_manufacturer"].ToString();
                string psu_name = psu_reader["psu_name"].ToString();
                string psu_wattage = psu_reader["psu_wattage"].ToString();
                string psu_certification = psu_reader["psu_certification"].ToString();
                psu_combobox.Items.Add($"{psu_manufacturer} {psu_name} {psu_wattage} {psu_certification}");
            }
            psu_reader.Close();
        }

        private void pc_case_line1()
        {
            case_combobox.Items.Clear();
            case_combobox.Items.Clear();
            pc_case_con = new SqlConnection(connection_string);
            pc_case_con.Open();

        }

        private void pc_case_line2()
        {
            pc_case_command = new SqlCommand(pc_case_query, pc_case_con);
            pc_case_reader = pc_case_command.ExecuteReader();
            while (pc_case_reader.Read())
            {
                string pc_manufacturer = pc_case_reader["pc_manufacturer"].ToString();
                string pc_model = pc_case_reader["pc_model"].ToString();
                string pc_formfactor = pc_case_reader["pc_formfactor"].ToString();
                string pc_color = pc_case_reader["pc_color"].ToString();
                case_combobox.Items.Add($"{pc_manufacturer} {pc_model} {pc_formfactor} {pc_color}");
            }
            pc_case_reader.Close();
        }

        private void cpu_cooler_line1()
        {
            cpu_cooler_combobox.Items.Clear();
            cpu_cooler_combobox.Items.Clear();
            cpu_cooler_con = new SqlConnection(connection_string);
            cpu_cooler_con.Open();

        }

        private void cpu_cooler_line2()
        {

        }

        private void line1()
        {
            gpu_line1();
            cpu_line1();
            mobo_line1();
            ram_line1();
            psu_line1();
            cpu_cooler_line1();
            pc_case_line1();
        }

        private void line2()
        {
            gpu_line2();
            cpu_line2();
            mobo_line2();
            ram_line2();
            psu_line2();
            cpu_cooler_line2();
            pc_case_line2();
        }

        private void price_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (price_combobox.SelectedIndex)
            {

                case 0:
                    line1();
                    gpu_query = "Select gpu_manufacturer, gpu_model from dbo.gpu";
                    cpu_query = "Select cpu_manufacturer, cpu_name from [cpu.dbo]";
                    mobo_query = "select mobo_manufacturer, mobo_name, mobo_chipset from dbo.mobo";
                    ram_query = "select ram_manufacturer, ram_name, ram_type, ram_capacity from dbo.ram";
                    psu_query = "select psu_manufacturer, psu_name, psu_wattage, psu_certification from dbo.psu";
                    pc_case_query = "select pc_manufacturer, pc_model, pc_formfactor, pc_color from dbo.pc_case";
                    line2();
                    break;
                case 1:
                    line1();
                    gpu_query = "SELECT gpu_manufacturer, gpu_model FROM dbo.gpu WHERE gpu_price_ratio = 'low end'";
                    cpu_query = "select cpu_manufacturer, cpu_name from [cpu.dbo] where cpu_price_ratio = 'low end'";
                    mobo_query = "select mobo_manufacturer, mobo_name, mobo_chipset from dbo.mobo where mobo_price_ratio = 'low end'";
                    ram_query = "select ram_manufacturer, ram_name, ram_type, ram_capacity from dbo.ram where ram_price_ratio = 'low end'";
                    psu_query = "select psu_manufacturer, psu_name, psu_wattage, psu_certification from dbo.psu where psu_price_ratio = 'low end'";
                    pc_case_query = "select pc_manufacturer, pc_model, pc_formfactor, pc_color from dbo.pc_case where pc_price_ratio = 'low end'";
                    line2();
                    break;
                case 2:
                    line1();
                    gpu_query = "SELECT gpu_manufacturer, gpu_model FROM dbo.gpu WHERE gpu_price_ratio = 'entry level'";
                    cpu_query = "select cpu_manufacturer, cpu_name from [cpu.dbo] where cpu_price_ratio = 'entry level'";
                    mobo_query = "select mobo_manufacturer, mobo_name, mobo_chipset from dbo.mobo where mobo_price_ratio = 'entry level'";
                    ram_query = "select ram_manufacturer, ram_name, ram_type, ram_capacity from dbo.ram where ram_price_ratio = 'entry level'";
                    psu_query = "select psu_manufacturer, psu_name, psu_wattage, psu_certification from dbo.psu where psu_price_ratio = 'entry level'";
                    pc_case_query = "select pc_manufacturer, pc_model, pc_formfactor, pc_color from dbo.pc_case where pc_price_ratio = 'entry level'";
                    line2();
                    break;
                case 3:
                    line1();
                    gpu_query = "SELECT gpu_manufacturer, gpu_model FROM dbo.gpu WHERE gpu_price_ratio = 'mid range'";
                    cpu_query = "select cpu_manufacturer, cpu_name from [cpu.dbo] where cpu_price_ratio = 'mid range'";
                    mobo_query = "select mobo_manufacturer, mobo_name, mobo_chipset from dbo.mobo where mobo_price_ratio = 'mid range'";
                    ram_query = "select ram_manufacturer, ram_name, ram_type, ram_capacity from dbo.ram where ram_price_ratio = 'mid range'";
                    psu_query = "select psu_manufacturer, psu_name, psu_wattage, psu_certification from dbo.psu where psu_price_ratio = 'mid range'";
                    pc_case_query = "select pc_manufacturer, pc_model, pc_formfactor, pc_color from dbo.pc_case where pc_price_ratio = 'mid range'";
                    line2();
                    break;
                case 4:
                    line1();
                    gpu_query = "SELECT gpu_manufacturer, gpu_model FROM dbo.gpu WHERE gpu_price_ratio = 'high end'";
                    cpu_query = "select cpu_manufacturer, cpu_name from [cpu.dbo] where cpu_price_ratio = 'high end'";
                    mobo_query = "select mobo_manufacturer, mobo_name, mobo_chipset from dbo.mobo where mobo_price_ratio = 'high end'";
                    ram_query = "select ram_manufacturer, ram_name, ram_type, ram_capacity from dbo.ram where ram_price_ratio = 'high end'";
                    psu_query = "select psu_manufacturer, psu_name, psu_wattage, psu_certification from dbo.psu where psu_price_ratio = 'high end'";
                    pc_case_query = "select pc_manufacturer, pc_model, pc_formfactor, pc_color from dbo.pc_case where pc_price_ratio = 'high end'";
                    line2();
                    break;
                case 5:
                    line1();
                    gpu_query = "SELECT gpu_manufacturer, gpu_model FROM dbo.gpu WHERE gpu_price_ratio = 'low end' or gpu_price_ratio = 'entry level'";
                    cpu_query = "select cpu_manufacturer, cpu_name from [cpu.dbo] where cpu_price_ratio = 'entry level' or cpu_price_ratio = 'low end'";
                    mobo_query = "select mobo_manufacturer, mobo_name, mobo_chipset from dbo.mobo where mobo_price_ratio = 'entry level' or mobo_price_ratio = 'low end'";
                    ram_query = "select ram_manufacturer, ram_name, ram_type, ram_capacity from dbo.ram where ram_price_ratio = 'low end' or ram_price_ratio = 'entry level'";
                    psu_query = "select psu_manufacturer, psu_name, psu_wattage, psu_certification from dbo.psu where psu_price_ratio = 'low end' or psu_price_ratio = 'entry level'";
                    pc_case_query = "select pc_manufacturer, pc_model, pc_formfactor, pc_color from dbo.pc_case where pc_price_ratio = 'low end' or pc_price_ratio = 'entry level'";
                    line2();
                    break;
                case 6:
                    line1();
                    gpu_query = "SELECT gpu_manufacturer, gpu_model FROM dbo.gpu WHERE gpu_price_ratio = 'low end' or gpu_price_ratio = 'entry level' or gpu_price_ratio = 'mid range'";
                    cpu_query = "select cpu_manufacturer, cpu_name from [cpu.dbo] where cpu_price_ratio = 'low end' or cpu_price_ratio = 'mid range' or cpu_price_ratio = 'entry level'";
                    mobo_query = "select mobo_manufacturer, mobo_name, mobo_chipset from dbo.mobo where mobo_price_ratio = 'entry level' or mobo_price_ratio = 'mid range' or mobo_price_ratio = 'low end'";
                    ram_query = "select ram_manufacturer, ram_name, ram_type, ram_capacity from dbo.ram where ram_price_ratio = 'low end' or ram_price_ratio = 'entry level' or ram_price_ratio = 'mid range'";
                    psu_query = "select psu_manufacturer, psu_name, psu_wattage, psu_certification from dbo.psu where psu_price_ratio = 'low end' or psu_price_ratio = 'entry level' or psu_price_ratio = 'mid range'";
                    pc_case_query = "select pc_manufacturer, pc_model, pc_formfactor, pc_color from dbo.pc_case where pc_price_ratio = 'low end' or pc_price_ratio = 'entry level' or pc_price_ratio = 'mid range'";
                    line2();
                    break;
                case 7:
                    line1();
                    gpu_query = "SELECT gpu_manufacturer, gpu_model FROM dbo.gpu WHERE gpu_price_ratio = 'entry level' or gpu_price_ratio = 'mid range'";
                    cpu_query = "select cpu_manufacturer, cpu_name from [cpu.dbo] where cpu_price_ratio = 'entry level' or cpu_price_ratio = 'mid range'";
                    mobo_query = "select mobo_manufacturer, mobo_name, mobo_chipset from dbo.mobo where mobo_price_ratio = 'entry level' or mobo_price_ratio = 'mid range'";
                    ram_query = "select ram_manufacturer, ram_name, ram_type, ram_capacity from dbo.ram where ram_price_ratio = 'entry level' or ram_price_ratio = 'mid range'";
                    psu_query = "select psu_manufacturer, psu_name, psu_wattage, psu_certification from dbo.psu where psu_price_ratio = 'entry level' or psu_price_ratio = 'mid range'";
                    pc_case_query = "select pc_manufacturer, pc_model, pc_formfactor, pc_color from dbo.pc_case where pc_price_ratio = 'entry level' or pc_price_ratio = 'mid range'";
                    line2();
                    break;
                case 8:
                    line1();
                    gpu_query = "SELECT gpu_manufacturer, gpu_model FROM dbo.gpu WHERE gpu_price_ratio = 'high end' or gpu_price_ratio = 'mid range' or gpu_price_ratio = 'entry level'";
                    cpu_query = "select cpu_manufacturer, cpu_name from [cpu.dbo] where cpu_price_ratio = 'high end' or cpu_price_ratio = 'mid range' or cpu_price_ratio = 'entry level'";
                    mobo_query = "select mobo_manufacturer, mobo_name, mobo_chipset from dbo.mobo where mobo_price_ratio = 'high end' or mobo_price_ratio = 'mid range' or mobo_price_ratio = 'entry level'";
                    ram_query = "select ram_manufacturer, ram_name, ram_type, ram_capacity from dbo.ram where ram_price_ratio = 'high end' or ram_price_ratio = 'mid range' or ram_price_ratio = 'entry level'";
                    psu_query = "select psu_manufacturer, psu_name, psu_wattage, psu_certification from dbo.psu where psu_price_ratio = 'entry level' or psu_price_ratio = 'mid range' or psu_price_ratio = 'high end'";
                    pc_case_query = "select pc_manufacturer, pc_model, pc_formfactor, pc_color from dbo.pc_case where pc_price_ratio = 'entry level' or pc_price_ratio = 'mid range' or pc_price_ratio = 'high end'";
                    line2();
                    break;
                case 9:
                    line1();
                    gpu_query = "SELECT gpu_manufacturer, gpu_model FROM dbo.gpu WHERE gpu_price_ratio = 'mid range' or gpu_price_ratio = 'high end'";
                    cpu_query = "select cpu_manufacturer, cpu_name from [cpu.dbo] where cpu_price_ratio = 'mid range' or cpu_price_ratio = 'high end'";
                    mobo_query = "select mobo_manufacturer, mobo_name, mobo_chipset from dbo.mobo where mobo_price_ratio = 'mid range' or mobo_price_ratio = 'high end'";
                    ram_query = "select ram_manufacturer, ram_name, ram_type, ram_capacity from dbo.ram where ram_price_ratio = 'mid range' or ram_price_ratio = 'high end'";
                    psu_query = "select psu_manufacturer, psu_name, psu_wattage, psu_certification from dbo.psu where psu_price_ratio = 'mid range' or psu_price_ratio = 'high end'";
                    pc_case_query = "select pc_manufacturer, pc_model, pc_formfactor, pc_color from dbo.pc_case where pc_price_ratio = 'mid range' or pc_price_ratio = 'high end'";
                    line2();
                    break;

            }
        }

    }
}
