using System;

namespace spending_calendar{
    public class Event{
        public Guid id;
        public string name;
        public string description;
        public DateTime timestamp;
        public Payment linkedPayment;

    }
}