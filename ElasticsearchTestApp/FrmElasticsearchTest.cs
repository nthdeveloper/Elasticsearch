using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nest;

namespace ElasticsearchTestApp
{
    public partial class FrmElasticsearchTest : Form
    {
        ElasticClient m_EsClient;

        public FrmElasticsearchTest()
        {
            InitializeComponent();
        }

        private void btnCreateClient_Click(object sender, EventArgs e)
        {
            ConnectionSettings settings = new ConnectionSettings(new Uri($"http://{txtServer.Text}:{((int)numPort.Value)}"));
            m_EsClient = new ElasticClient(settings);
        }

        private void btnCreateIndex_Click(object sender, EventArgs e)
        {
            var settings = new IndexSettings { NumberOfReplicas = 1, NumberOfShards = 2 };

            var indexConfig = new IndexState
            {
                Settings = settings
            };

            if (!m_EsClient.IndexExists(txtIndexName.Text).Exists)
            {
                var _response = m_EsClient.CreateIndex(txtIndexName.Text, c => c
                    .InitializeUsing(indexConfig)
                    .Mappings(m => m.Map<Post>(mp => mp.AutoMap()))
                );
            }           
        }

        private void btnDeleteIndex_Click(object sender, EventArgs e)
        {
            if (m_EsClient.IndexExists(txtIndexName.Text).Exists)
            {
                var _response = m_EsClient.DeleteIndex(txtIndexName.Text);
            }
        }

        private void btnAddDocument_Click(object sender, EventArgs e)
        {
            var newPost = new Post
            {
                Id = (int)numPostId.Value,
                PostDate = datePostDate.Value,
                PostText = txtPostContent.Text
            };

            var _response = m_EsClient.Index(newPost, i => i.Index(txtIndexName.Text).Type("post").Id(newPost.Id));
        }

        private void btnGetDocument_Click(object sender, EventArgs e)
        {
            var response = m_EsClient.Get<Post>(new DocumentPath<Post>((int)numPostId.Value), 
                desc => desc
                .Index(txtIndexName.Text)
                .Type("post"));

            Post _doc = response.Source;
        }

        private void btnUpdateDocument_Click(object sender, EventArgs e)
        {
            var updatedPost = new Post
            {
                Id = (int)numPostId.Value,
                PostDate = datePostDate.Value,
                PostText = txtPostContent.Text
            };

            var response = m_EsClient.Update<Post>(new DocumentPath<Post>((int)numPostId.Value), 
                desc => desc
                .Index(txtIndexName.Text)
                .Type("post")
                .Doc(updatedPost));
        }

        private void btnDeleteDocument_Click(object sender, EventArgs e)
        {
            var response = m_EsClient.Delete<Post>(new DocumentPath<Post>((int)numPostId.Value), 
                desc => desc
                .Index(txtIndexName.Text)
                .Type("post"));
        }

        /*
        private void doTermQuery()
        {
            var result = m_EsClient.Search<Post>(s =>
            s.From(0)
            .Size(100)
            .Index(txtIndexName.Text)
            .Type("post")
            .Query(p => p.Term(d => d.PostText, "some")));
        }
        */
    }
}
