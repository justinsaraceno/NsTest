﻿using NUnit.Framework;

namespace NServiceBus.Unicast.Subscriptions.Mongo.Tests
{
    [TestFixture]
    public class When_receiving_a_unsubscription_message : MongoFixture
    {
        [Test]
        public void All_subscription_entries_for_specfied_message_types_should_be_removed()
        {
            Storage.Subscribe(TestClients.ClientA, MessageTypes.All);

            Storage.Unsubscribe(TestClients.ClientA, MessageTypes.All);


            var count = Subscriptions.Count();
            Assert.AreEqual(0, count);
        }
    }
}