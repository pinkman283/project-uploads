import { Body, Controller, Post, UseGuards, ValidationPipe } from '@nestjs/common';
import { FeedbackService } from './feedback.service';
import { FeedbackCheck } from './dto/feedbackCheck.dto';
import { AuthGuard } from '@nestjs/passport';

@Controller('feedback')
export class FeedbackController {
    constructor(private readonly feedserv: FeedbackService) {}
    @UseGuards(AuthGuard('jwt'))
    @Post('submit-feedback')
    submit(@Body(new ValidationPipe()) ab:FeedbackCheck )
    {
        return this.feedserv.submit(ab);
    }
}
