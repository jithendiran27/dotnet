using Transactions;

Balances abc54321 = new Balances();

abc54321.balance = 10000;

abc54321.creditOperation += SendSms.amountCredited;

abc54321.debitOperation += SendSms.amountDebited;

abc54321.debit(1000);



