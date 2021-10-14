using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileUploadtoAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Browse_Click(object sender, EventArgs e) // dosyaları bilgisayardan seçebilmek için buton 
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "All files|*.*" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                    txtFileName.Text = ofd.FileName;
            }
        }
        private async void Upload_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(FileName.Text))
            {
                string url = ""; // api adresi girilmesi 
                IRestResponse restResponse = await this.UploadAsync(FileName.Text, url);
                if (restResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    MessageBox.Show("You have successfully uploaded the file", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async Task<IRestResponse> UploadAsync(string fileName, string server)
        {
            using (var fileStream = File.Open(fileName, FileMode.Open))
            {
                var client = new RestClient(server);
                var request = new RestRequest(Method.POST);
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    await fileStream.CopyToAsync(memoryStream);
                    request.AddFile("file", memoryStream.ToArray(), fileName);
                    request.AlwaysMultipartFormData = true;
                    var response = await client.ExecuteTaskAsync(request);
                    return response;
                }
            }
        }
    }
}
