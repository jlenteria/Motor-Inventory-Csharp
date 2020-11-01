/*
 * Created by SharpDevelop.
 * User: HackDaFOX
 * Date: 09/13/2018
 * Time: 09:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace Semifinal_Activity_1
{
	/// <summary>
	/// Interaction logic for View.xaml
	/// </summary>
	public partial class View : Window
	{
		motorcyclelist motor;
		bool is_input_;
		public View(bool is_view_only = false)
		{
		
			InitializeComponent();
			is_input_ = false;
		}
		public void Set(motorcyclelist value)
		{
			motor = value;
			DataContext = motor;
		}
		public bool Result(ref motorcyclelist value)
		{
			value = motor;
			return is_input_;
		}
		void button1_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}
	
	 
	}
}