using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class SalerInfo : Form
    {
        public SalerInfo()
        {
            InitializeComponent();
        }

        private async void SalerInfo_Load(object sender, EventArgs e)
        {
            await GetSalerInfoesAsync().ContinueWith(r=> {
                if (dataGridView1.InvokeRequired)
                {
                    this.Invoke(new BindDelegate(Bind), r.Result);
                }
                else
                {
                    Bind(r.Result);
                }
            });
        }

        delegate void BindDelegate(List<Models.SalerDb.SalerInfo> salerInfos);
        void Bind(List<Models.SalerDb.SalerInfo> salerInfos)
        {
            dataGridView1.DataSource = salerInfos;
        }

        static async Task<List<Models.SalerDb.SalerInfo>> GetSalerInfoesAsync()
        {
            string path = "/api/SalerInfoes";
            HttpResponseMessage response = await Program.client.GetAsync(path);
            var r= await response.Content.ReadAsAsync<List<Models.SalerDb.SalerInfo>>();
            return r;
        }
    }
}
