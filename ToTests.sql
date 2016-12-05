
/*
Getting posts with comments
*/
SELECT p.Id, p.Date, p.Title, p.PostTxt, c.CommentTxt, c.PostId 
FROM dbo.Posts p
LEFT JOIN dbo.Comments c ON c.PostId = p.Id;