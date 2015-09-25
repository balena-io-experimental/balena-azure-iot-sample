add_custom_target(common_tests)

set(CMAKE_C_FLAGS "${CMAKE_C_FLAGS} -g -std=c99 -DUSING_PTHREAD -pthread \
	-Wall -Wfatal-errors -Wno-missing-braces -Wextra \
    -Wno-missing-field-initializers -Wformat=2 \
    -Wswitch-default -Wcast-align -Wpointer-arith \
    -Wbad-function-cast -Wstrict-overflow=5 -Wstrict-prototypes -Winline \
    -Wundef -Wnested-externs -Wshadow -Wunreachable-code \
    -Wlogical-op -Wfloat-equal -Wstrict-aliasing=2 \
    -Wold-style-definition -Werror -Wno-unused-function -Wno-unused-value -Wno-unused-variable \
	-DUSE_CTEST \
	-DGB_DEBUG_ALLOC -DGB_MEASURE_MEMORY_FOR_THIS")

set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} -g -Wall -Wfatal-errors -DUSE_CTEST -std=c++0x -Wno-unused-function -Wno-unused-variable -Wno-unused-value \
    -DGB_DEBUG_ALLOC -DGB_MEASURE_MEMORY_FOR_THIS")

add_subdirectory(agenttime_unittests)
add_subdirectory(base64_unittests)
add_subdirectory(buffer_unittests)
add_subdirectory(crtabstractions_unittests)
add_subdirectory(doublylinkedlist_unittests)
add_subdirectory(gballoc_unittests)
add_subdirectory(gballoc_without_init_unittests)
add_subdirectory(hmacsha256_unittests)
add_subdirectory(httpapiex_unittests)
add_subdirectory(httpapiexsas_unittests)
add_subdirectory(httpheaders_unittests)
add_subdirectory(lock_unittests)
add_subdirectory(map_unittests)
add_subdirectory(sastoken_unittests)
add_subdirectory(string_tokenizer_unittests)
add_subdirectory(strings_unittests)
add_subdirectory(urlencode_unittests)
add_subdirectory(vector_unittests)
