   M S B A M L   `   `   `  ����B  >Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:LibraryLibrary  5   	       Library.BorrowBook   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Library     5   	     � Title$  Borrow Book Page��5   	   $	��200��6"   $	��620��6/   .��5	      � $��0,0,-1.667,-0.373q�6   .+�5
   
   �� $��	Book Id :��6   $
��Left=�6$   $��25,8,0,0q�6?   $	��Top=�6Q   $��Ink Free)�6i   $
��Bold"�6   $��25��6�   $��75��6�   �� 5   
   -   5         ��Name$ BookIdTxtBx��5      $
��Left=�6'   $��	87,12,0,0q�6B    �� TextWrapping$
 Wrap=�6U   $	��Top=�6i   $	��219��6�   $��Ink Free)�6�   $
��Bold"�6�   $��17��6�   �� 5   
   $��	User Id :��6   $
��Left=�6$   $��	318,8,0,0q�6?   $	��Top=�6R   $��Ink Free)�6j   $
��Bold"�6�   $��25��6�   $��75��6�   �� 5   
   -   5        $ UserIdTxtBx��5      $
��Left=�6'   $��
379,13,0,0q�6B   $
 Wrap=�6V   $	��Top=�6j   $	��219��6�   $��Ink Free)�6�   $
��Bold"�6�   $��17��6�   �� 5   
   $
��Left=�6   $��	85,86,0,0q�6/   $	��Top=�6B   $��46��6Z   $	��483��6f   �� 5   
   -   5         ��Name$ 	BorrowBtn��5      $��Borrow��6$   $
��Left=�65   $��244,129,0,0q�6P   $	��Top=�6e   $��56��6}   $��24��6�   $
��Bold"�6�   $��Ink Free)�6�   6�   �� 5   
   -   5        $ BackBtn��5      $
��Back��6"   $
��Left=�61   $��337,129,0,0q�6L   $	��Top=�6a   $��56��6y   $��24��6�   $
��Bold"�6�   $��Ink Free)�6�   6�   �� 5   
   $��Return Date :��6   $
��Left=�6(   $��	62,56,0,0q�6C   $	��Top=�6V   $��Ink Free)�6n   $
��Bold"�6�   $��25��6�   $��88��6�   �� 5   
   $��Deadline Date :��6   $
��Left=�6*   $��315,58,0,88.04q�6E   $��Center=�6]   $��Ink Free)�6x   $
��Bold"�6�   $��25��6�   $��93��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ ReturnDateDP��5      $
��Left=�6+   $��
156,58,0,0q�6F   $	��Top=�6Z   $	��133��6r   $��Ink Free)�6~   $
��Bold"�6�     5   
   -   5        $ DeadlineDateDp��5      $
��Left=�6-   $��
421,59,0,0q�6H   $	��Top=�6\   $	��133��6t   $��Ink Free)�6�   $
��Bold"�6�   5      5      