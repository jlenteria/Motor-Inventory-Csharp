/*
 * Created by SharpDevelop.
 * User: HackDaFOX
 * Date: 12/09/2018
 * Time: 9:46 AM
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
	/// Interaction logic for Window1.xaml
	/// </summary>
	public class motorcyclelist
	{
		public string Speeds{get;set;}
		public string Name{get;set;}
		public int Speed{get;set;}
		public int  Price{get;set;}
		public string Types{get;set;}
		public string Image{get;set;}
		public string Power{get;set;}
		public string Engine{get;set;}
		public string Color{get;set;}
		public string Safety{get;set;}
		public string Capacity{get;set;}
		public string Size{get;set;}
		public string Quality{get;set;}
		public int IsSelected{get;set;}	
		
	}
	
	
	
		
	public partial class Window1 : Window
	{
		motorcyclelist motor;
		bool is_input_;
		List<motorcyclelist>motorcyclelist_;
		List<motorcyclelist>list;
		public Window1()
		{
			
			InitializeComponent();
			list = new List<motorcyclelist>(){	
			};
			motorcyclelist_ = new List<motorcyclelist>(){
				new motorcyclelist(){Image ="Chopper.jpg",Name = "RATO", Speed = 800, Price = 80000, Types = "Chopper",Power = "100 Power",Engine = "100 CC",Size = "Big", Color = "Red", Quality = "Good",Safety = "Safety",Capacity = "2 Persons"},
				new motorcyclelist(){Image = "cross.jpg", Name = "Kawasaki KLX250", Speed = 500,Price = 90000, Types = "MotoCross",Power = "200 Power",Engine = "2000 CC",Size = "Small", Color = "Black", Quality = "Good",Safety = "Not Safety",Capacity = "2 Persons"},
				new motorcyclelist(){Image = " enduro.jpg", Name = "YZ450FX Enduro", Speed = 500, Price = 70000, Types = "Enduro",Power = "150 Power",Engine = "1000 CC",Size = "Big", Color = "Blue", Quality = "Good",Safety = "Safety",Capacity = "2 Persons"},
				new motorcyclelist(){Image = "cruiser.jpg", Name = "Bolt R-Spec", Speed = 200,Price = 40000, Types = "Cruiser",Power = "125 Power",Engine = "100 CC",Size = "Small", Color = "Yellow", Quality = "Good",Safety = "Safety",Capacity = "2 Persons"},
				new motorcyclelist(){Image = "atv.jpg", Name = "Bull ATV", Speed = 800,Price = 100000, Types = "ATV",Power = "115 Power",Engine = "500 CC",Size = "Big", Color = "Pink", Quality = "Good",Safety = "Safety",Capacity = "2 Persons"},
				new motorcyclelist(){Image ="touring.jpg",Name = "BMW", Speed = 400,Price = 60000, Types = "Touring",Power = "200 Power",Engine = "500 CC",Size = "Small", Color = "Gray", Quality = "Good",Safety = "Safety",Capacity = "2 Persons"},
				new motorcyclelist(){Image = "naked.jpg", Name = "KTM Duke", Speed = 300,Price = 70000, Types = "Naked",Power = "100 Power",Engine = "500 CC",Size = "Big", Color = "LightBlue", Quality = "Good",Safety = "Not Safety",Capacity = "2 Persons"},
				new motorcyclelist(){Image = " street.jpg", Name = "Ducati", Speed = 500, Price = 80000, Types = "Street",Power = "100 Power",Engine = "500 CC",Size = "Big", Color = "Orange", Quality = "Good",Safety = "Safety",Capacity = "2 Persons"},
				new motorcyclelist(){Image = " sportourist.jpg", Name = "Tracer", Speed = 500,Price = 150000, Types = "Sport Touring",Power = "150 Power",Engine = "1000 CC",Size = "Big", Color = "Green", Quality = "Good",Safety = "Safety",Capacity = "2 Persons"},
				new motorcyclelist(){Image = " sport.jpg", Name = "Ninja", Speed = 1000,Price = 70000, Types = "Sport",Power = "100 Power",Engine = "100 CC",Size = "Small", Color = "Red", Quality = "Good",Safety = "Safety",Capacity = "2 Persons"},
			};
			motorcycle_list.ItemsSource = motorcyclelist_;
			
		}
		void addBtn_Click(object sender, RoutedEventArgs e)
		{
			
			var add_mo = new add_window();
			var new_motorcycles = new motorcyclelist();
			add_mo.Set(new_motorcycles);
			add_mo.ShowDialog();
			
			if(add_mo.Result(ref new_motorcycles)){
				motorcyclelist_.Add(new_motorcycles);
				motorcycle_list.ItemsSource = null;
				motorcycle_list.ItemsSource = motorcyclelist_;
				
				MessageBox.Show("Data Is Added successfully!");
			}
		
			
				
		}
		void viewBtn_Click(object sender, RoutedEventArgs e)
		{
			
			if(motorcycle_list.SelectedItem !=null)
			{
				var view_window = new View(true);
				var view_data = motorcycle_list.SelectedItem as motorcyclelist;
				view_window.Set(view_data);
				view_window.ShowDialog();
			}
			else{
				MessageBox.Show("Select in the Motorcyclelist First!");
				return;
			}
			
			
		}
		void editBtn_Click(object sender, RoutedEventArgs e)
		{
			if(motorcycle_list.SelectedItem !=null){
				var edit = new Edit();
				var edit_data = motorcycle_list.SelectedItem as motorcyclelist;
				edit.Set(edit_data);
				edit.ShowDialog();
			}
			else{
				MessageBox.Show("Select in the Motorcyclelist First!");
				return;
			}
		}
		void deleteBtn_Click(object sender, RoutedEventArgs e)
		{
			if(motorcycle_list.SelectedItem !=null)
			{
				var del_data = motorcycle_list.SelectedItem as motorcyclelist;
				if(MessageBox.Show("Are You sure You want to Delete this?","Confirmation",MessageBoxButton.YesNo,MessageBoxImage.Information) == MessageBoxResult.Yes)
				{
					if(motorcyclelist_.Remove(del_data))
					{
						motorcycle_list.ItemsSource = null;
						motorcycle_list.ItemsSource = motorcyclelist_;
						MessageBox.Show("Data Is Deleted successfully!");
					}
				}
				else{
					
					return;
				}
				
			}
			else
			{
				MessageBox.Show("Select in the Motorcyclelist First!");
				return;
			}
		}
		void selectBtn_Click(object sender, RoutedEventArgs e)
		{
			
			if(motorcycle_list.SelectedItem !=null)
			{
				
				var scan_data = new motorcyclelist();
				scan_data = motorcycle_list.SelectedItem as motorcyclelist;
				if(MessageBox.Show("Do you want to select?","Confirmation",MessageBoxButton.YesNo,MessageBoxImage.Information) == MessageBoxResult.Yes){
				if(scan_data.IsSelected == 0)
					{
						list.Add(scan_data);
						selected_motor.ItemsSource = null;
						selected_motor.ItemsSource = list;
						scan_data.IsSelected = 1;
						MessageBox.Show("Data is Added to the Selected Motorycles Tab Successfully!");
					}
				}
				else{
					return;
				}
				
			}
			else{
				MessageBox.Show("Select in the Motorcyclelist First!");
				return;
			}
		}
		void prevBtn_Click(object sender, RoutedEventArgs e)
		{
			if(motorcycle_list.SelectedIndex < motorcycle_list.Items.Count)
			{
				motorcycle_list.SelectedIndex++;
			}
		}
		void nextBtn_Click(object sender, RoutedEventArgs e)
		{
			if(motorcycle_list.SelectedIndex>0)
			{
				motorcycle_list.SelectedIndex--;
			}
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
		void listbox_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			var view = new View();
			var view_data = motorcycle_list.SelectedItem as motorcyclelist;
			view.Set(view_data);
			view.ShowDialog();
		}
		void button1_Click(object sender, RoutedEventArgs e)
		{
			if(MessageBox.Show("CONTINUE? ","Confirmation!",MessageBoxButton.OKCancel,MessageBoxImage.Information) == MessageBoxResult.OK){
				MessageBox.Show("\n\nT H A N K  Y O U");
				Close();
			}
			else{
				return;
			}
		}

		
		
	}
}