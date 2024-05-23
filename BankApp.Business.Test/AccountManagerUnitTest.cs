using Moq;
namespace BankApp.Business.Test
{
    //class MockAccountRepository : IAccountRepository
    //{
    //    public bool Save(string msg)
    //    {
    //        return true;
    //    }
    //}


    [TestClass]
    public class AccountManagerUnitTest // test suits
    {
        AccountManager target = null;
        Account account = null;
        Mock<IAccountRepository> mock = null;

        [TestInitialize]
        public void Init()
        {
            mock = new Mock<IAccountRepository>();
            mock.Setup(m => m.Save($"Deposit,111,1000,{DateTime.Now}")).Returns(true);


            target = new AccountManager(mock.Object);
            account = new Account { AccNo = 111, CurrentBalance = 0, IsActive = true, MinBalance = 1000, Pin = 1234 };
        }

        [TestCleanup]

        public void Cleanup()
        {
            target = null;
            mock = null;
            account = null;
        }


        [TestMethod]
        public void Deposit_ProvideValidInput_ShouldIncreaseBalance() // test cases for testing balance increase
        {
            // no conditional stmt - if...else/switch
            // no iterative stmt - for/while/foreach
            // no ex handling - try/catch/finaly

            // AAA approach
            // A - Arrange
            //Account account = new Account { AccNo = 111, CurrentBalance = 0, IsActive = true, MinBalance = 1000, Pin = 1234 };
            int amount = 1000;
            int expected = 1000;
            //AccountManager target = new AccountManager(new MockAccountRepository());
            // A - Act
            target.Deposit(account, amount);
            // A - Assert
            //if(account.CurrentBalance == expected) { }
            Assert.AreEqual(expected, account.CurrentBalance);


        }

        [TestMethod]
        public void Deposit_WithValidInput_ShouldReturnTrue()
        {
            //Account account = new Account { AccNo = 111, CurrentBalance = 0, IsActive = true, MinBalance = 1000, Pin = 1234 };
            int amount = 1000;
            bool expected = true;
            //AccountManager target = new AccountManager();
            // A - Act
            bool actual = target.Deposit(account, amount);
            // A - Assert
            //if(account.CurrentBalance == expected) { }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidAmountException))]
        public void Deposit_WithLessthanMimimumAmount_ShouldThrowExp()
        {
            //Account account = new Account { AccNo = 111, CurrentBalance = 0, IsActive = true, MinBalance = 1000, Pin = 1234 };
            //AccountManager target = new AccountManager();
            bool actual = target.Deposit(account, 100);
        }

        [TestMethod]
        [ExpectedException(typeof(InactiveAccountException))]
        public void Deposit_WithInactiveAccount_ShouldThrowExp()
        {
            //Account account = new Account { AccNo = 111, CurrentBalance = 0, IsActive = false, MinBalance = 1000, Pin = 1234 };
            //AccountManager target = new AccountManager();
            account.IsActive = false;
            target.Deposit(account, 1000);
        }


        [TestMethod]
        public void Deposit_WithValidInput_ShouldCallSaveMethod()
        {
            target.Deposit(account, 1000);
            //Mock.Verify(mocmocks.Verify(m => m.Save()));
            mock.Verify(m => m.Save($"Deposit,{account.AccNo},1000,{DateTime.Now}"), Times.Once());

        }

    }
}