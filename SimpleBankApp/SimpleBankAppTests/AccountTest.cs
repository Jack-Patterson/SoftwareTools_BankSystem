using SimpleBankApp;
using NUnit.Framework;
using System.Xml.Linq;

namespace SimpleBankAppTests
{
    public class AccountTest
    {
        Account account = new Account(1, "JoeJoe Bloggs", "IE55BOFI93969645631245", 101010, 5058.66f);

        [Test]
        public void testGetAccountID()
        {
            int accountID = account.getAccountId();

            Assert.That(accountID, Is.EqualTo(1));
        }

        [Test]
        public void testGetAccountName()
        {
            String name  = account.getAccountName();

            Assert.That(name, Is.EqualTo("JoeJoe Bloggs"));
        }

        [Test]
        public void testGetIban()
        {
            String iban = account.getIban();

            Assert.That(iban, Is.EqualTo("IE55BOFI93969645631245"));
        }

        [Test]
        public void testGetPac()
        {
            int pac = account.getPac();

            Assert.That(pac, Is.EqualTo(101010));
        }

        [Test]
        public void testGetBalance()
        {
            float balance = account.getBalance();

            Assert.That(balance, Is.EqualTo(5058.66f));
        }
    }
}
