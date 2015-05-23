﻿/// Agent can be used to query the Agent endpoints
module Fakta.Agent

/// CheckDeregister is used to deregister a check with the local agent
let checkDeregister (state : FaktaState) (checkId : string) : Async<Choice<unit, Error>> =
  raise (TBD "TODO")

/// CheckRegister is used to register a new check with the local agent 
let checkRegister (state : FaktaState) (checkId : string) : Async<Choice<unit, Error>> =
  raise (TBD "TODO")

/// Checks returns the locally registered checks
let checks (state : FaktaState) : Async<Choice<Map<string, AgentCheck>, Error>> =
  raise (TBD "TODO")

/// DisableNodeMaintenance toggles node maintenance mode off for the agent we are connected to.
let disableNodeMaintenance (state : FaktaState) : Async<Choice<unit, Error>> =
  raise (TBD "TODO")

/// DisableServiceMaintenance toggles service maintenance mode off for the given service id.
let disableServiceMaintenance (state : FaktaState) (serviceId : Id) : Async<Choice<unit, Error>> =
  raise (TBD "TODO")

/// EnableNodeMaintenance toggles node maintenance mode on for the agent we are connected to.
let enableNodeMaintenance (state : FaktaState) (reason : string) : Async<Choice<unit, Error>> =
  raise (TBD "TODO")

/// EnableServiceMaintenance toggles service maintenance mode on for the given service id.
let enableServiceMaintenance (state : FaktaState) (serviceId : Id) (reason : string) : Async<Choice<unit, Error>> =
  raise (TBD "TODO")

/// FailTTL is used to set a TTL check to the failing state
let failTTL (state : FaktaState) (checkId : string) (note : string) : Async<Choice<unit, Error>> =
  raise (TBD "TODO")

/// ForceLeave is used to have the agent eject a failed node
let forceLeave (state : FaktaState) (node : string) : Async<Choice<unit, Error>> =
  raise (TBD "TODO")

/// Join is used to instruct the agent to attempt a join to another cluster member
let join (state : FaktaState) (addr : string) (wan : bool) : Async<Choice<unit, Error>> =
  raise (TBD "TODO")

/// Members returns the known gossip members. The WAN flag can be used to query a server for WAN members.
let members (state : FaktaState) (addr : string) (wan : bool) : Async<Choice<unit, Error>> =
  raise (TBD "TODO")

/// NodeName is used to get the node name of the agent
let nodeName (state : FaktaState) : Async<Choice<string, Error>> =
  raise (TBD "TODO")

/// PassTTL is used to set a TTL check to the passing state
let passTTL (state : FaktaState) (checkId : string) (note : string) : Async<Choice<unit, Error>> =
  raise (TBD "TODO")

/// Self is used to query the agent we are speaking to for information about itself
let self (state : FaktaState) : Async<Choice<Map<string, Map<string, Chiron.Json>>, Error>> =
  raise (TBD "TODO")

/// ServiceDeregister is used to deregister a service with the local agent
let serviceDeregister (state : FaktaState) (serviceId : Id) : Async<Choice<unit, Error>> =
  raise (TBD "TODO")

/// ServiceRegister is used to register a new service with the local agent
let serviceRegister (state : FaktaState) (service : AgentServiceRegistration) : Async<Choice<unit, Error>> =
  raise (TBD "TODO")

/// Services returns the locally registered services
let services (state : FaktaState) : Async<Choice<Map<string, AgentService>, Error>> =
  raise (TBD "TODO")

/// UpdateTTL is used to update the TTL of a check
let updateTTL (state : FaktaState) (checkId : string) (note : string) (status : string) : Async<Choice<unit, Error>> =
  raise (TBD "TODO")

/// WarnTTL is used to set a TTL check to the warning state
let warnTTL (state : FaktaState) (checkId : string) (note : string) (status : string) : Async<Choice<unit, Error>> =
  raise (TBD "TODO")