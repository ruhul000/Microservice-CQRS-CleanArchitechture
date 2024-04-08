﻿using Application.Abstractions.Messaging;
using Domain.Entities;

namespace Application.Products.Commands.CreateProduct;

public sealed record CreateProductCommand(string Name, string? Description, decimal? Price) : ICommand<Result<Product>>;

