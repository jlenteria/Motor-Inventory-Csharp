/*
 * Created by SharpDevelop.
 * User: HackDaFOX
 * Date: 09/13/2018
 * Time: 01:33
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
	/// Interaction logic for add_window.xaml
	/// </summary>

	public partial class add_window : Window
	{
	
		int speeds;
		int price;
		motorcyclelist motor;
		bool is_input_;
		List<motorcyclelist>motors_;
		public add_window(bool is_view_only = false)
		{
			
			InitializeComponent();
	
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
		void AddBtn_Click(object sender, RoutedEventArgs e)
		{	
			int.TryParse(price_textbox.Text,out price);
			int.TryParse(speed_textbox.Text,out speeds);
			if(pict1.IsSelected == false && pict2.IsSelected == false && pict3.IsSelected == false && pict4.IsSelected == false && pict5.IsSelected == false && pict6.IsSelected == false && pict7.IsSelected == false && pict8.IsSelected == false && pict9.IsSelected == false && pict10.IsSelected == false && pict11.IsSelected == false)
			{
				MessageBox.Show("Choose Image/Type First!");
				return;
				
			}
			if(name_textbox.Text == ""||capacity_textbox.Text == "" || color_textbox.Text == "" || size_textbox.Text == ""||quality_textbox.Text == ""||safety_textbox.Text == "")
			{
				MessageBox.Show("Please Fill Up all First!");
				return;
			}
			else if(power200.IsSelected == false && power180.IsSelected == false && power150.IsSelected == false && power125.IsSelected == false && power115.IsSelected == false && power100.IsSelected == false)
			{
				MessageBox.Show("Select Power First!");
				return;
			}
			else if(cc500.IsSelected == false && cc2000.IsSelected == false && cc150.IsSelected == false && cc1000.IsSelected== false && cc100.IsSelected == false){
				MessageBox.Show("Select Engine First!");
				return;
			}
			else if(speeds<=0||speeds>1000)
			{
				MessageBox.Show("Invalid Speed!");
				return;
			}
			else if(price<=0 || price <20000)
			{
				MessageBox.Show("Invalid Price!");
				return;
			}
			
		
            if(MessageBox.Show("Continue?","Confirmation",MessageBoxButton.YesNo,MessageBoxImage.Information) == MessageBoxResult.Yes)
			{
				if(pict1.IsSelected == true)
				{
					motor.Image = "enduro.jpg";
					motor.Types = "Enduro";
				}
				else if(pict2.IsSelected == true){
					motor.Image = "naked.jpg";
					motor.Types = "Naked";
				}
				else if(pict3.IsSelected == true)
				{
					motor.Image = "atv.jpg";
					motor.Types = "ATV";
				}
				else if(pict4.IsSelected == true){
					motor.Image = "chopper.jpg";
					motor.Types = "Chopper";
				}
				else if(pict5.IsSelected == true)
				{
					motor.Image = "cross.jpg";
					motor.Types = "MotoCross";
				}
				else if(pict6.IsSelected == true){
					motor.Image = "cruiser.jpg";
					motor.Types = "Cruiser";
				}
				else if(pict7.IsSelected == true)
				{
					motor.Image = "scooter.jpg";
					motor.Types = "Scooter";
				}
				else if(pict8.IsSelected == true){
					motor.Image = "sport.jpg";
					motor.Types = "Sport";
				}
				else if(pict9.IsSelected == true)
				{
					motor.Image = "sportourist.jpg";
					motor.Types = "Sport Tourist";
				}
				else if(pict10.IsSelected == true){
					motor.Image = "street.jpg";
					motor.Types = "Street";
				}
				else if(pict11.IsSelected == true)
				{
					motor.Image = "touring.jpg";
					motor.Types = "Touring";
				}
				
				motorcycle_list.ItemsSource = motors_;
				
				if(power100.IsSelected == true)
				{
					motor.Power = "100 Power";
				}
				else if(power115.IsSelected == true)
				{
					motor.Power = "155 Power";
				}
				else if(power125.IsSelected == true)
				{
					motor.Power = "125 Power";
				}
				else if(power150.IsSelected == true)
				{
					motor.Power = "150 Power";
				}
				else if(power180.IsSelected == true)
				{
					motor.Power = "180 Power";
				}
				else if(power200.IsSelected == true)
				{
					motor.Power = "200 Power";
				}
				
				if(cc100.IsSelected == true)
				{
					motor.Engine = "100 CC ";
				}
				else if(cc1000.IsSelected == true)
				{
					motor.Engine = "1000 CC";
				}
				else if(cc2000.IsSelected == true)
				{
					motor.Engine = "2000 CC";
				}
				else if(cc500.IsSelected == true)
				{
					motor.Engine = "500 CC";
				}
				else if(cc150.IsSelected == true)
				{
					motor.Engine = "150 CC";
				}
				is_input_ = true;
				Close();
				
			}
			else{
				return;
			}
			
		}
		void button1_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}
		
	}
}