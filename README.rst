.. image:: https://travis-ci.org/rienafairefr/SharpYNAB.svg?branch=master
    :target: https://travis-ci.org/rienafairefr/SharpYNAB

.. image:: https://ci.appveyor.com/api/projects/status/nwxyogku2q5tqwyf?svg=true
    :target: https://ci.appveyor.com/project/rienafairefr/SharpYNAB

.. image:: https://coveralls.io/repos/github/rienafairefr/SharpYNAB/badge.svg?branch=master
    :target: https://coveralls.io/github/rienafairefr/SharpYNAB?branch=master

.. image:: https://img.shields.io/badge/license-MIT-blue.svg

========
SharpYNAB
========

a C# .NET Core client for the YNAB API

It's a port, with some rewriting, of pynYNAB a python client for YNAB (www.youneedabudget.com)

This is a beta release, Sync seems to work but Push not yet tested.

=========
Usage
=========

You need to create an Args object that contains the email/password/budget name that will be used to connect to YNAB

    var args = new Args{Email="**youremail**", "Password"="**yourpassword**", BudgetName="Test Budget"}

If no budget with that name exists, this should fail with a BudgetNotFoundException

Then use this to create a client:

    var client = ClientFactory.CreateClient(args);

To query YNAB data

    client.Sync();

To push data, modify the client.Budget and client.Catalog objects collections, for example

    client.Budget.Transactions.Add(new Transaction{
        // transaction properties, see SharpYNAB.Schema.Budget.Transaction
    });

Then push

    client.Push(1);

Here I'm pushing a single modification, like adding an entity. For more involved scenarii (like adding an account, or transfer transactions), you need to push more entities. 
SharpYNAB protects your data at that point by forbidding you to push more that what you explicitely intend to modify
