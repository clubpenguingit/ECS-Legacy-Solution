using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace _1234
{
    [TestFixture()]
    public class Class1
    {
        [Test]
        public void tet()
        {
            Assert.That(true, Is.True);
        }
    }
}
