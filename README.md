# HighLightText
Highlight portion of text.

On StackOverflow, after succesful answering of a question about finding correct coordinates of intended portion to highlight, 
I realized that there might be others who might need to do the same accurately. 
First of all, it is imperative that we implicitely use GDI DrawText function to measure and draw text. 
Using TextRender or GDI32 to accomplish the measurement and draw text does not help at all and 
I am saying it by my experience - I gained through developing TextBox on my own from scratch neither inheriting from
Microsoft.TextBox nor Microsoft.RichTextBox. There were tonnes of issues but majors being accrulate caret positioning 
and selection of text.
This demo application does highlight the portion of Text but only for single line.
You can have gradient background of highlighted text.
It works accurately for fixed as well as non fixed font.
