   M S B A M L   `   `   `  ����B  >Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:LibraryLibrary  5   	       Library.AddNewMember   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Library     5   	     � Title$  Add New Member Page ��5   	   $	��300��6&   $��647.333��63   .��5	      � $��2,0,2.667,6.667q�6   .+�5
   
   �� $��First Name :��6   $
��Left=�6'   $��	25,14,0,0q�6B   $	��Top=�6U   $��Ink Free)�6m   $
��Bold"�6�   $��24��6�   �� 5   
   -   5         ��Name$ FirstNameTxtBx��5      $
��Left=�6*   $��
102,19,0,0q�6E    �� TextWrapping$
 Wrap=�6Y   $	��Top=�6m   $	��135��6�   $��Ink Free)�6�   $
��Bold"�6�   �� 5   
   $��
LastName :��6   $
��Left=�6%   $��
254,14,0,0q�6@   $	��Top=�6T   $��Ink Free)�6l   $
��Bold"�6�   �� 5   
   -   5        $ LastNameTxtBx��5      $
��Left=�6)   $��
325,19,0,0q�6D   $
 Wrap=�6X   $	��Top=�6l   $	��135��6�   $��Ink Free)�6�   $
��Bold"�6�   �� 5   
   $��Email :��6   $
��Left=�6"   $��	56,45,0,0q�6=   $	��Top=�6P   $��Ink Free)�6h   $
��Bold"�6~   $��24��6�   �� 5   
   -   5        $ 
EmailTxtBx��5      $
��Left=�6&   $��
102,48,0,0q�6A   $
 Wrap=�6U   $	��Top=�6i   $	��219��6�   $��Ink Free)�6�   $
��Bold"�6�   �� 5   
   $��
Username :��6   $
��Left=�6%   $��
336,45,0,0q�6@   $	��Top=�6T   $��Ink Free)�6l   $
��Bold"�6�   $��24��6�   �� 5   
   -   5        $ UsernameTxtBx��5      $
��Left=�6)   $��
406,48,0,0q�6D   $
 Wrap=�6X   $	��Top=�6l   $	��212��6�   $��Ink Free)�6�   $
��Bold"�6�   �� 5   
   $��
Password :��6   $
��Left=�6%   $��
339,70,0,0q�6@   $	��Top=�6T   $��Ink Free)�6l   $
��Bold"�6�   $��24��6�   �� 5   
   -   5        $ PhoneNumberTxtBx��5      $
��Left=�6,   $��
102,74,0,0q�6G   $
 Wrap=�6[   $	��Top=�6o   $	��219��6�   $��Ink Free)�6�   $
��Bold"�6�   �� 5   
   $��Phone Number :��6   $
��Left=�6)   $��	10,70,0,0q�6D   $	��Top=�6W   $��Ink Free)�6o   $
��Bold"�6�   $��24��6�   �� 5   
   $��Birth Date :��6   $
��Left=�6'   $��169,140,0,0q�6B   $	��Top=�6W   $��Ink Free)�6o   $
��Bold"�6�   $��24��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ BirthDateDP��5      $
��Left=�6*   $��248,140,0,0q�6E   $	��Top=�6Z   $	��218��6r   $��Ink Free)�6~   $
��Bold"�6�   $��24��6�   �� 5   
   $
��Left=�6   $��
86,165,0,0q�6/   $	��Top=�6C   $��24��6[   $	��522��6g    J� RenderTransformOrigin$ 0.5,0.5&�6s   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -0.183Q�6&   T� 5      5      5       �� 5!   
   -   5         ��Name$ SaveBtn��5!      $
��Save��6"   $
��Left=�61   $��245,205,0,0q�6L   $	��Top=�6a   $��84��6y   $��Ink Free)�6�   $
��Bold"�6�   $��23��6�   6�   �� 5"   
   -   5        $ BackBtn��5"      $
��Back��6"   $
��Left=�61   $��347,205,0,0q�6L   $	��Top=�6a   $��84��6y   $��23��6�   $ 0.509,0.545&�6�   $��Ink Free)�6�   $
��Bold"�6�   6�   �� 5#   
   $��Education :��6   $
��Left=�6&   $��174,106,0,0q�6A   $	��Top=�6V   $��Ink Free)�6n   $
��Bold"�6�   $��24��6�   �� 5$   
   -	   5        $ EducationTxtBx��5$      $
��Left=�6*   $��249,111,0,0q�6E   $
 Wrap=�6Z   $	��Top=�6n   $	��219��6�   $��Ink Free)�6�   $
��Bold"�6�   G� 5%   
   -
   5         G�Name$ PasswordTxtBx��5%      $
��Left=�6-   $��
406,75,0,0q�6H   $	��Top=�6\   $	��212��6t    G� PasswordChar$ *��6�   $��Ink Free)�6�   $
��Bold"�6�   �� 5&   
   -   5        	 ��Name$	 
GenderCmBx��5&      $��21��6'   $��496,17,18,0q�63   $	��Top=�6H   
 �� Text$
 Gender��6`   $��Ink Free)�6n   $
��Bold"�6�    �� 
IsEditable .  �� 
IsReadOnly .  �� IsDropDownOpen .   �� StaysOpenOnEdit . .@�5)      �� $
��Male��6   $
��Left=�6*   $��117.333333333333��6E   �� 5*      $��Female��6   $
��Left=�6,   $��117.333333333333��6G   5+      5-      5.      