targetScope = 'local'

extension local

resource sayHello 'Command' = {
  command: 'gh auth status'
}

output stdout string? = sayHello.stdOut
