
namespace Basket.API.Basket.DeleteBasket
{
    public record DeleteBasketCommand(string UserName) : ICommand<DeleteBasketResult>;
    public record DeleteBasketResult(bool IsSuccess);
    public class DeleteCommandValidator : AbstractValidator<DeleteBasketCommand> {
        public DeleteCommandValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Username is Required");
        }
    }
    public class DeleteBasketCommandHandler(IBasketRepository repository)
        : ICommandHandler<DeleteBasketCommand, DeleteBasketResult>
    {
        public async Task<DeleteBasketResult> Handle(DeleteBasketCommand command, CancellationToken cancellationToken)
        {
            var isDelete = await repository.DeleteBasket(command.UserName, cancellationToken);
            return new DeleteBasketResult(isDelete);
        }
    }
}
