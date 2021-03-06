//
// https://github.com/mythz/ServiceStack.Redis
// ServiceStack.Redis: ECMA CLI Binding to the Redis key-value storage system
//
// Authors:
//   Demis Bellot (demis.bellot@gmail.com)
//
// Copyright 2013 ServiceStack.
//
// Licensed under the same terms of Redis and ServiceStack: new BSD license.
//

using System;
using NServiceKit.Common.Extensions;
using NServiceKit.Messaging;

namespace NServiceKit.Redis.Messaging
{
	public class RedisTransientMessageService
		: TransientMessageServiceBase
	{
		private readonly RedisTransientMessageFactory messageFactory;

		public RedisTransientMessageService(int retryAttempts, TimeSpan? requestTimeOut,
			RedisTransientMessageFactory messageFactory)
			: base(retryAttempts, requestTimeOut)
		{
			messageFactory.ThrowIfNull("messageFactory");
			this.messageFactory = messageFactory;
		}

		public override IMessageFactory MessageFactory
		{
			get { return messageFactory; }
		}
	}

}