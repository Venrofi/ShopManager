﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShopManager.View.UserControls
{
    public partial class RootLoginControl : UserControl
    {
        public RootLoginControl()
        {
            InitializeComponent();
        }
        #region Dependencies
        public static readonly DependencyProperty BackButtonProperty = DependencyProperty.Register(
            "BackButton", typeof(ICommand), typeof(RootLoginControl), new FrameworkPropertyMetadata(null)
            );
        public static readonly DependencyProperty LogProperty = DependencyProperty.Register(
            "Log", typeof(ICommand), typeof(RootLoginControl), new FrameworkPropertyMetadata(null)
            );
        public static readonly DependencyProperty LoginProperty = DependencyProperty.Register(
            "Login", typeof(string), typeof(RootLoginControl), new FrameworkPropertyMetadata(null)
            );
        public static readonly DependencyProperty PasswordProperty = DependencyProperty.Register(
            "Password", typeof(string), typeof(RootLoginControl), new FrameworkPropertyMetadata(null)
            );
        #endregion
        #region Getters & setters
        public ICommand BackButton
        {
            get { return (ICommand)GetValue(BackButtonProperty); }
            set { SetValue(BackButtonProperty, value); }
        }
        public ICommand Log
        {
            get { return (ICommand)GetValue(LogProperty); }
            set { SetValue(LogProperty, value); }
        }
        public ICommand Login
        {
            get { return (ICommand)GetValue(LoginProperty); }
            set { SetValue(LoginProperty, value); }
        }
        public ICommand Password
        {
            get { return (ICommand)GetValue(PasswordProperty); }
            set { SetValue(PasswordProperty, value); }
        }
        #endregion
        #region Events
        public static readonly RoutedEvent BackButtonClickEvent =
            EventManager.RegisterRoutedEvent("OtherRootBackButtonClick", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(LoginControl));
        public event RoutedEventHandler BackButtonClick
        {
            add { AddHandler(BackButtonClickEvent, value); }
            remove { RemoveHandler(BackButtonClickEvent, value); }
        }
        public static readonly RoutedEvent LogClickEvent =
            EventManager.RegisterRoutedEvent("OtherRootLogClick", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(LoginControl));
        public event RoutedEventHandler LogClick
        {
            add { AddHandler(LogClickEvent, value); }
            remove { RemoveHandler(LogClickEvent, value); }
        }
        void RaiseLogClick(object sender, SelectionChangedEventArgs e)
        {
            RoutedEventArgs args = new RoutedEventArgs(LogClickEvent);
            RaiseEvent(args);
        }
        #endregion
    }
}
