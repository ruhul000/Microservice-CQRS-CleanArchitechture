﻿using MediatR;

namespace Application.Abstractions.Messaging;

public interface ICommand<out TResponse> : IRequest<TResponse>
{
}
//public interface ICommand : IBaseCommand
//{
//}
//public interface ICommand<TResponse> : IBaseCommand
//{
//}
//public interface IBaseCommand
//{
//}