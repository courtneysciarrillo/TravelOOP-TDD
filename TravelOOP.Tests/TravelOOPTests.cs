using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelOOP.Tests
{ //Courtney Sciarrillo 7/2/18
    [TestFixture]
    class TravelOOPTests
    {
        [Test]
        public void Test_Default_CTR()
        {
            var travel = new Travel();

            var result = travel.FirstName = "FName";

            Assert.That(result, Is.EqualTo("FName"));
        }

        [Test]

        public void Test_LastName_Prop()
        {
            var travel = new Travel();

            var result = travel.LastName = "LName";

            Assert.That(result, Is.EqualTo("LName"));
        }

        [Test]

        public void Test_Address_Prop()
        {
            var travel = new Travel();

            var result = travel.Address = " ";

            Assert.That(result, Is.EqualTo(" "));
        }

        [Test]

        public void Test_Email_Prop()
        {
            var travel = new Travel();

            var result = travel.Email = " ";

            Assert.That(result, Is.EqualTo(" "));
        }

        [Test]

        public void Test_Date_Travel_Method()
        {
            int month = 9;
            int day = 8;
            int year = 2018;
            var travel = new Travel();

            var result = travel.GetDate(month, day, year);

            Assert.That(result, Is.EqualTo("9/8/2018"));
        }

        [Test]

        public void Test_Total_Travel_Time_Method()
        {
            int month = 9;
            int day = 13;
            int year = 2018;
            var travel = new Travel();

            var result = travel.TtlTravel(month, day, year);

            Assert.That(result, Is.EqualTo(5));
        }

        [Test]

        public void Selection_Method()
        {
            var travel = new Travel();

            var result = travel.GetSelection(5);

            Assert.That(result, Is.EqualTo("Cali"));
        }

        [Test]

        public void Selection_Method_4_Georgia()
        {
            var travel = new Travel();

            var result = travel.GetSelection(4);

            Assert.That(result, Is.EqualTo("Georgia"));
        }

        //This will test the function of the GetSelection method.
        //This test MUST accept the following value parementer as integer 4.
        //The test MUST return a value in the following string format "Georgia".

        [Test]

        public void Selection_Method_3_Florida()
        {
            var travel = new Travel();

            var result = travel.GetSelection(3);

            Assert.That(result, Is.EqualTo("Florida"));
        }

        //This will test the function of the GetSelection method.
        //This test MUST accept the following value parementer as integer 3.
        //The test MUST return a value in the following string format "Florida".

        [Test]

        public void Selection_Method_2_Nashville()
        {
            var travel = new Travel();

            var result = travel.GetSelection(2);

            Assert.That(result, Is.EqualTo("Nashville"));
        }

        //This will test the function of the GetSelection method.
        //This test MUST accept the following value parementer as integer 2.
        //The test MUST return a value in the following string format "Nashville".

        [Test]

        public void Selection_Method_1_Put_in_Bay()
        {
            var travel = new Travel();

            var result = travel.GetSelection(1);

            Assert.That(result, Is.EqualTo("Put in Bay"));
        }

        //This will test the function of the GetSelection method.
        //This test MUST accept the following value parementer as integer 1.
        //The test MUST return a value in the following string format "Put in Bay".

        [Test]

        public void Selection_Method_0_Stay_Home()
        {
            var travel = new Travel();

            var result = travel.GetSelection(0);

            Assert.That(result, Is.EqualTo("Stay Home"));
        }

        //This will test the function of the GetSelection method.
        //This test MUST accept the following value parementer as integer 0.
        //The test MUST return a value in the following string format "Stay Home".

        [Test]

        public void Selection_Method_Greater_Than_5()
        {
            var travel = new Travel();

            var result = travel.GetSelection(6);

            Assert.That(result, Is.EqualTo("The World is Yours"));
        }

        //This will test the function of the GetSelection method.
        //This test MUST accept the following value parementer as integer 6.
        //The test MUST return a value in the following string format "The World is Yours".

        [Test]

        public void Selection_Method_Greater_Than_5_Destination()
        {
            var destination = new Destination();

            var result = destination.GetSelection(6);

            Assert.That(result, Is.EqualTo("The World is Yours"));
        }

        //This will test the instantiation of the Destination class.
        //This will test the function of the GetSelection method.
        //This test MUST accept the following value parementer as integer 6.
        //The test MUST return a value in the following string format "The World is Yours".

        //[Test]

        //public void Selection_Method_5_Destination_TTT_Method_Input()
        //{
        //    var destination = new Destination();

        //    var result = destination.GetSelection(destination.TtlTravel(9, 14, 2018));

        //    Assert.That(result, Is.EqualTo("The World is Yours"));
        //}

        //This will test the instantiation of the Destination class.
        //This will test the function of the GetSelection method.
        //This test MUST accept the following method as a parameter TtlTravel(9, 14, 2018).
        //The test MUST return a value in the following string format "The World is Yours".

        [Test]

        public void Selection_Method_5_Destination_TTT_Method_Input()
        {
            var destination = new Destination();

            var result = destination.GetSelection(destination.TtlTravel(9, 13, 2018));

            Assert.That(result, Is.EqualTo("Cali"));
        }

        //This will test the instantiation of the Destination class.
        //This will test the function of the GetSelection method.
        //This test MUST accept the following method as a parameter TtlTravel(9, 13, 2018).
        //The test MUST return a value in the following string format "Cali".

    }
}
