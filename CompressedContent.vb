Namespace Tools

    ' https://programmer.help/blogs/httpclient-and-aps.net-web-api-compression-and-decompression-of-request-content.html

    Public Class CompressedContent
        Inherits Net.Http.HttpContent

        Private ReadOnly _OriginalContent As Net.Http.HttpContent = Nothing

        Public Sub New(content As Net.Http.HttpContent)
            _OriginalContent = content

            For Each Current As KeyValuePair(Of String, IEnumerable(Of String)) In _OriginalContent.Headers
                Headers.TryAddWithoutValidation(Current.Key, Current.Value)
            Next

            Headers.ContentEncoding.Add("gzip")
        End Sub

        Protected Overrides Async Function SerializeToStreamAsync(stream As IO.Stream, context As Net.TransportContext) As Task
            Using output As New IO.Compression.GZipStream(stream, IO.Compression.CompressionMode.Compress, True)
                Await _OriginalContent.CopyToAsync(output)
            End Using
        End Function

        Protected Overrides Function TryComputeLength(ByRef length As Long) As Boolean
            length = -1

            Return False
        End Function

    End Class

End Namespace