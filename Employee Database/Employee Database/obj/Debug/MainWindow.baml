   M S B A M L   `   `   `  ����L  HEmployee Database, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Employee_DatabaseEmployee_Database  5   	   "    Employee_Database.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Employee_Database     5   	     � Title$  Employee Database��5	   	    � WindowStartupLocation$ CenterScreen=�6#   $	��450��6H   $	��800��6U   .��5
      �  � RowDefinitions 5   
   �� 5      �� 5      $��2* �6    � ColumnDefinitions 5   
   �� 5      �� 5      ��5   
   �� 5       �� ImageSource$ images/background.jpg��6   6?   .+�5   
   (� $��0��6   $��2��6   .��5      �� $��Employee Database��6   $
��Bold"�60    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         ShadowDepth$ 4Q�6'      	Direction$	 280Q�5         Color$ Black��5      	   Opacity$		 0.5Q�5      6)   5       5!      (� 5#   
   $��1��6   $��0��6   $��20q�6/   $	��300��6;   $��90��6G   .��5$      �� -   5        $��View Records��5$      
������ $
��Bold"�6X   
����+�� 5%        5&      $ 4Q�6'   $	 280Q�5'      $ Black��5(      $		 0.5Q�5)      6)   5+      5,      (� 5.   
   $��1��6   $��1��6   $��20q�6/   $	��300��6;   $��90��6G   .��5/      �� -   5        $��Add Records��5/      
������ $
��Bold"�6X   
����+�� 50        51      $ 4Q�6'   $	 280Q�52      $ Black��53      $		 0.5Q�54      6)   56      57      58      59      