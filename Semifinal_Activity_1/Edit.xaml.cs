/*
 * Created by SharpDevelop.
 * User: HackDaFOX
 * Date: 09/13/2018
 * Time: 12:12
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
	/// Interaction logic for Edit.xaml
	/// </summary>
	public partial class Edit : Window
	{
		
		int speeds;
		int price;
		motorcyclelist motor;
		bool is_input_;
		List<motorcyclelist>motors_;
		public Edit()
		{
			
			InitializeComponent();
			

		}
		public void Set(motorcyclelist value)
		{
			motor = value;
			DataContext = motor;
		}
		void Edit_Click(object sender, RoutedEventArgs e)
		{
			int.TryParse(speed_textbox.Text,out speeds);
			int.TryParse(price_textbox.Text,out price);
			
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
				
				is_input_=true;
				Close();
			}
			else
			{
				return;
			}
			
		}
		
	}
}