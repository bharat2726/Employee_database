   M S B A M L   `   `   `  ����L  HEmployee Database, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Employee_DatabaseEmployee_Database  5   	   #    Employee_Database.RecordsList   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Employee_Database     5   	     � Title$  RecordsList��5	   	   $	��450��6    � WindowStartupLocation$ CenterScreen=�6*   $	��800��6O   .��5
      �  � RowDefinitions 5   
   �� 5      $��4* �6   �� 5      ��5   
   �� 5       �� ImageSource$ images/background.jpg��6   6?   .+�5   
   (� $��0��6   $��5q�6   .��5      �� -   5        $��
RecordList��5   !   $��5q�6    �� SelectedIndex$ -1��5   1   ��6   �� *Record+ �� SelectedItem 5      �� *SelectedRecord+5      5      (� 5   
   $��1��6   $��5q�6   .��5      �� -   5        $��Close��5      
������ 
���  ��$��60��6i   $
��Bold"�6t    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         ShadowDepth$ 4Q�6'      	Direction$	 280Q�5       	   Color$	 Black��5!      
   Opacity$	
 0.5Q�5"      6)   5$      5%      5&      5'      