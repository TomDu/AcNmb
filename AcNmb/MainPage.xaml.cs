using AcNmb.Core;
using AcNmb.Core.Data;
using AcNmb.Core.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AcNmb
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private EntityReader entityReader;

        public MainPage()
        {
            this.InitializeComponent();
            entityReader = new EntityReader();

            ForumList.ItemsSource = DB.ForumList;
        }

        private async void ForumSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Forum item = (sender as ListView).SelectedItem as Forum;

            if(item == null)
            {
                return;
            }

            IList<PostAndReplies> postList = await entityReader.GetPostList(item.Id, 0);
            PostList.ItemsSource = postList;
        }

        private async void PostSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PostAndReplies item = (sender as ListView).SelectedItem as PostAndReplies;

            if (item == null)
            {
                return;
            }

            PostAndReplies post = await entityReader.GetPost(item.Id, 0);
            PostAndReplyList.ItemsSource = post.Replies;
        }
    }
}
