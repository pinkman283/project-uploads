import { IS_NOT_EMPTY, IsNotEmpty } from "class-validator";

export class FeedbackCheck{
    

    @IsNotEmpty({message:'comment for the review'})
    comment:string

    @IsNotEmpty({message:'fill the rating'})
    rating:number


}