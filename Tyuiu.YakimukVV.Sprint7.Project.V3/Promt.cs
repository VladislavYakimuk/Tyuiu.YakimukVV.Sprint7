﻿using System;
using System.Windows.Forms;

public static class Prompt
{
    public static string ShowDialog(string text, string caption)
    {
        Form prompt = new Form()
        {
            Width = 400,
            Height = 150,
            FormBorderStyle = FormBorderStyle.FixedDialog,
            Text = caption,
            StartPosition = FormStartPosition.CenterScreen
        };

        Label textLabel = new Label() { Left = 20, Top = 20, Text = text, AutoSize = true };
        TextBox inputBox = new TextBox() { Left = 20, Top = 50, Width = 340 };
        Button confirmation = new Button() { Text = "ОК", Left = 270, Width = 90, Top = 80, DialogResult = DialogResult.OK };

        confirmation.Click += (sender, e) => { prompt.Close(); };
        prompt.Controls.Add(textLabel);
        prompt.Controls.Add(inputBox);
        prompt.Controls.Add(confirmation);
        prompt.AcceptButton = confirmation;

        return prompt.ShowDialog() == DialogResult.OK ? inputBox.Text : string.Empty;
    }
}
