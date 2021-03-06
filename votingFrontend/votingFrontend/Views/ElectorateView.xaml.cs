﻿// <copyright file="ElectorateView.xaml.cs" company="UCOL 3rd Year Bachelor of Information and Communication Assignment">
// Copyright (c) UCOL 3rd Year Bachelor of Information and Communication Assignment. All rights reserved.
// </copyright>

namespace VotingFrontend.Views
{
    using VotingFrontend.Services;
    using VotingFrontend.ViewModels;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;

    /// <summary>
    /// Displays Electorates for the user to choose from
    /// </summary>
    public sealed partial class ElectorateView : Page
    {
        // ViewModel Object for the related ViewModel
        private ElectorateViewModel electorateVM;

        /// <summary>
        /// Initializes a new instance of the <see cref="ElectorateView"/> class.
        /// </summary>
        public ElectorateView()
        {
            this.InitializeComponent();

            this.electorateVM = new ElectorateViewModel(new NavigationService());
            this.DataContext = this.electorateVM;
        }

        /// <summary>
        /// When an item is selected the DataTemplate for the selected item is changed to a more detailed view and any other items DataTemplate is changed to the detault view
        /// </summary>
        /// <param name="sender">The Object that called this method</param>
        /// <param name="e">Event arguments for the object that called this method</param>
        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (var item in e.AddedItems)
            {
                ListViewItem lvi = (sender as ListView).ContainerFromItem(item) as ListViewItem;
                lvi.ContentTemplate = (DataTemplate)this.Resources["Detailed"];
            }

            foreach (var item in e.RemovedItems)
            {
                ListViewItem lvi = (sender as ListView).ContainerFromItem(item) as ListViewItem;
                lvi.ContentTemplate = (DataTemplate)this.Resources["Normal"];
            }
        }
    }
}
