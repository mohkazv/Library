   M S B A M L   `   `   `  ����B  >Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:LibraryLibrary  5   	       Library.SignUp   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Library     5   	   -   5          �Name$  SignUp1��5   	    � Title$ Sign Up Page ��5   	   $��322.667��6   $	��660��60   .��5	      � $��0,0,-2.667,-0.333q�6   .+�5
   
   �� $��First Name :��6   $
��Left=�6'   $��	32,55,0,0q�6B   $	��Top=�6U   $��Ink Free)�6m   $
��Bold"�6�   $��24��6�   �� 5   
   -   5         ��Name$ FirstNameTxtBx��5      $
��Left=�6*   $��
109,59,0,0q�6E    �� TextWrapping$
 Wrap=�6Y   $	��Top=�6m   $	��135��6�   $��Ink Free)�6�   $
��Bold"�6�   �� 5   
   $��
LastName :��6   $
��Left=�6%   $��
261,55,0,0q�6@   $	��Top=�6T   $��Ink Free)�6l   $
��Bold"�6�   �� 5   
   -   5        $ LastNameTxtBx��5      $
��Left=�6)   $��
333,59,0,0q�6D   $
 Wrap=�6X   $	��Top=�6l   $	��135��6�   $��Ink Free)�6�   $
��Bold"�6�   �� 5   
   $��Email :��6   $
��Left=�6"   $��	63,86,0,0q�6=   $	��Top=�6P   $��Ink Free)�6h   $
��Bold"�6~   $��24��6�   �� 5   
   -   5        $ 
EmailTxtBx��5      $
��Left=�6&   $��
109,89,0,0q�6A   $
 Wrap=�6U   $	��Top=�6i   $	��219��6�   $��Ink Free)�6�   $
��Bold"�6�   �� 5   
   $��
Username :��6   $
��Left=�6%   $��
343,86,0,0q�6@   $	��Top=�6T   $��Ink Free)�6l   $
��Bold"�6�   $��24��6�   �� 5   
   -   5        $ UsernameTxtBx��5      $
��Left=�6)   $��
413,89,0,0q�6D   $
 Wrap=�6X   $	��Top=�6l   $	��212��6�   $��Ink Free)�6�   $
��Bold"�6�   �� 5   
   $��
Password :��6   $
��Left=�6%   $��346,111,0,0q�6@   $	��Top=�6U   $��Ink Free)�6m   $
��Bold"�6�   $��24��6�   �� 5   
   -   5        $ PhoneNumberTxtBx��5      $
��Left=�6,   $��109,115,0,0q�6G   $
 Wrap=�6\   $	��Top=�6p   $	��219��6�   $��Ink Free)�6�   $
��Bold"�6�   �� 5   
   $��Phone Number :��6   $
��Left=�6)   $��
17,111,0,0q�6D   $	��Top=�6X   $��Ink Free)�6p   $
��Bold"�6�   $��24��6�   �� 5   
   $��Birth Date :��6   $
��Left=�6'   $��173,183,0,0q�6B   $	��Top=�6W   $��Ink Free)�6o   $
��Bold"�6�   $��24��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ BirthDateDP��5      $
��Left=�6*   $��250,183,0,0q�6E   $	��Top=�6Z   $	��223��6r   $��Ink Free)�6~   $
��Bold"�6�   $��25��6�   �� 5   
   $
��Left=�6   $��
73,210,0,0q�6/   $	��Top=�6C   $��24��6[   $	��522��6g    J� RenderTransformOrigin$ 0.5,0.5&�6s   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -0.183Q�6&   T� 5      5      5       �� 5!   
   -   5         ��Name$ 	SignUpBtn��5!      $��Sign Up��6$   $
��Left=�66   $��278,242,0,0q�6Q   $	��Top=�6f   $��84��6~   $��Ink Free)�6�   $
��Bold"�6�   $��23��6�   6�   �� 5"   
   $��Education :��6   $
��Left=�6&   $��181,148,0,0q�6A   $	��Top=�6V   $��Ink Free)�6n   $
��Bold"�6�   $��24��6�   �� 5#   
   -	   5        $ EducationTxtBx��5#      $
��Left=�6*   $��253,153,0,0q�6E   $
 Wrap=�6Z   $	��Top=�6n   $	��222��6�   $��Ink Free)�6�   $
��Bold"�6�   �� 5$   
   -
   5         ��Name$ 
GenderCmBx��5$      $��21��6'   $��536,57,32,0q�63   $	��Top=�6H   	 �� Text$	 Gender��6`   $��Ink Free)�6n   $
��Bold"�6�   
 �� 
IsEditable
 .  �� 
IsReadOnly .  �� IsDropDownOpen .   �� StaysOpenOnEdit . $ 0.555,0.551&�5%   ;   z�5&      V� 5'      .~�5(      �� �� 5)      �� 5*      $ -0.031Q�6&   T� 5+      5,      .@�5.      �� $
��Male��6   $
��Left=�6*   $��117.333333333333��6E   �� 5/      $��Female��6   $
��Left=�6,   $��117.333333333333��6G   50      G� 51   
   -   5         G�Name$ PasswordTxtBx��51      $
��Left=�6-   $��413,117,0,0q�6H   $	��Top=�6]   $	��212��6u    G� PasswordChar$ *��6�   $��Ink Free)�6�   $
��Bold"�6�   �� 52   
   -   5         ��Name$ textblockTxB��52      $
��Left=�6*   $��80,7,0,0q�6E   $
��Wrap=�6W   $	��Top=�6k   $	��314��6�   $��27��6�   $��Ink Free)�6�   $
��Bold"�6�   $��14(�6�   �� 53   
   $
��Left=�6   $��	79,25,0,0q�6/   $	��Top=�6B   $��24��6Z   $	��522��6f   $ 0.5,0.5&�6r   z�54      V� 55      .~�56      �� �� 57      �� 58      $ -0.183Q�6&   T� 59      5:      5<      5>      5?      