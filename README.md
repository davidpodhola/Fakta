# Fakta

A Consul and Vault F# API.

The aim is to support both Consul and Vault from the same library, because it's
a common deployment scenario. You should be able to use the Consul bits without
using the Vault bits.

Fakta is Swedish for 'facts', a fitting name for a library interacting with a
CP-oriented fact store.

Sponsored by
[qvitoo – A.I. bookkeeping](https://qvitoo.com/?utm_source=github&utm_campaign=fakta).

## API

How much has been implemented? This API surface is the same as that of the
official [Go client][go-client].

Those not implemented will throw a correspond TBD-exception.

### Justification

The current implementation's use-case (for me) is [leader-election][docs-LE] and semi- to
long-term storage of access keys that need be requested exactly-once or they
get invalidated.

Together with [Registrator][reg] and this library, F# code can participate in micro-
service architectures easily.

## Compiling and running initial tests

First, run:

``` bash
./tools/consul.sh agent -dev -bind 127.0.0.1
```

Then in another terminal:

``` bash
bundle exec rake
```

Which will call xbuild/msbuild and compile the project, run unit tests and then
finally run the integration tests.

## Milestones

[All Milestones](https://github.com/haf/Fakta/milestones)

Prio 1 is what is needed to get a PoC up and running.
Prio 2 is next, by being good to have.
Prio 3 is next.

The order of Consul vs Vault priorities is:

 - Vault Prio 1
 - Consul Prio 1
 - Vault Prio 2
 - Consul Prio 2
 - etc

Note that Vault is on top, because all the Prio 0's of Consul are already done.

## References

### Consul

 - [The HTTP API](https://www.consul.io/docs/agent/http.html)
 - [go-client](https://godoc.org/github.com/hashicorp/consul/api) – the library
   is partially modelled after this

### Vault

 - [Official Ruby Client](https://github.com/hashicorp/vault-ruby/tree/master/lib/vault/api)
 - [Official Ruby Client Docs](http://www.rubydoc.info/gems/vault/0.1.5)
 - [The HTTP API](https://vaultproject.io/docs/http/index.html)

### [KV][docs-KV]

 - [ ] acquire
 - [ ] CAS
 - [ ] delete
 - [ ] deleteCAS
 - [ ] deleteTree
 - [ ] getRaw
 - [x] get
 - [ ] keys
 - [x] list
 - [x] put
 - [ ] release

### [Session][docs-Session]

 - [x] create
 - [ ] createNoChecks
 - [x] destroy
 - [ ] info
 - [ ] list
 - [ ] node
 - [ ] renew
 - [ ] renewPeriodic

### Service

## Helping Out

All development is done on `master` branch which should always be release-able;
write unit tests for your changes and it shall be fine.

### Compiling

You compile with Rake/albacore, the best build system for .Net/mono:

```
bundle
bundle exec rake
```

### Running Tests

The unit tests are run by just running the Tests-executable, or by using rake:

```
bundle exec rake tests:unit
```

### Running Integration Tests

You'll need to start consul first; in one console:

```
bundle exec foreman start
```

...and then running the tests:

```
bundle exec rake tests:integration
```

 [go-client]: https://godoc.org/github.com/hashicorp/consul/api
 [docs-LE]: https://www.consul.io/docs/guides/leader-election.html
 [docs-KV]: https://www.consul.io/docs/agent/http/kv.html
 [docs-Session]: https://www.consul.io/docs/agent/http/session.html
 [reg]: https://github.com/gliderlabs/registrator
