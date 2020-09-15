using FibonacciSequenceDemo.Helpers;
using FibonacciSequenceDemo.Service.Abstract;
using FibonacciSequenceDemo.Service.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FibonacciSequenceDemo
{
    public partial class Form1 : Form
    {
        private readonly IFibonacciSequenceService fibonacciSequenceService;
        private StringBuilder validSequences;
        private StringBuilder invalidSequences;
        private int[] sequences;
        private bool isSubmitted;

        public Form1()
        {
            InitializeComponent();
            fibonacciSequenceService = new FibonacciSequenceService();
            invalidSequences = new StringBuilder();
            validSequences = new StringBuilder();
            isSubmitted = false;
        }

        private void addRandomBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(maxNoTextField.Text))
                {
                    MessageBox.Show("Sequence Max number cannot be empty...enter a value.");
                }
                else
                {
                    if (isSubmitted == true)
                    {
                        invalidSequences = new StringBuilder();
                        validSequences = new StringBuilder();
                    }

                    isSubmitted = false;

                    //clear the result labels
                    maxNumRsltLbl.Text = string.Empty;
                    invalidSeqRsltLbl.Text = string.Empty;
                    validSeqRsltLbl.Text = string.Empty;

                    var maxValue = maxNoTextField.Text;
                    maxNoTextField.Enabled = false;

                    var random = randomTextField.Text;

                    if (string.IsNullOrEmpty(random))
                        MessageBox.Show("You have to enter a random sequence.");

                    //generate fibonacci sequence using max value

                    sequences = fibonacciSequenceService.GenerateSequence(maxValue);
                    var exist = sequences.Contains(Convert.ToInt32(random));

                    randomTextField.Text = string.Empty;

                    if (!exist)
                    {
                        invalidSequences.Append(random + ",  ");
                        MessageBox.Show($"Invalid number in the sequence --> {random}.");
                    }
                    else
                    {
                        validSequences.Append(random + ",  ");
                        MessageBox.Show($"Valid number in the sequence --> {random}.");
                    }

                    randomTextField.Text = string.Empty;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            maxNumRsltLbl.Text = maxNoTextField.Text;
            invalidSeqRsltLbl.Text = invalidSequences.ToString();
            validSeqRsltLbl.Text = validSequences.ToString();

            maxNoTextField.Enabled = true;
            maxNoTextField.Text = string.Empty;
            isSubmitted = true;
        }
    }
}
